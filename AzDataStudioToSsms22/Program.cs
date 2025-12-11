using System.Text.Json;
using System.Xml.Serialization;
using AzDataStudioToSsms22;

// Check command line arguments
if (args.Length < 1)
{
    Console.WriteLine("Usage: AzDataStudioToSsms22 <source.json> [destination.xml]");
    Console.WriteLine("  source.json: Path to the Azure Data Studio connections JSON file");
    Console.WriteLine("  destination.xml: Path to the output SSMS22 XML file (optional, defaults to output.xml)");
    return 1;
}

string sourceFile = args[0];
string destinationFile = args.Length > 1 ? args[1] : "output.xml";

try
{
    // Validate source file exists
    if (!File.Exists(sourceFile))
    {
        Console.WriteLine($"Error: Source file '{sourceFile}' not found.");
        return 1;
    }

    Console.WriteLine($"Reading source file: {sourceFile}");
    
    // Read and deserialize JSON
    string jsonContent = File.ReadAllText(sourceFile);
    var dataSource = JsonSerializer.Deserialize<DataSource>(jsonContent, new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

    if (dataSource == null)
    {
        Console.WriteLine("Error: Failed to deserialize JSON file.");
        return 1;
    }

    Console.WriteLine($"Found {dataSource.connectionGroups.Count} connection groups and {dataSource.connections.Count} connections");

    // Transform to SSMS22 format
    var registeredServers = TransformToSsms22(dataSource);

    // Serialize to XML
    Console.WriteLine($"Writing destination file: {destinationFile}");
    var xmlSerializer = new XmlSerializer(typeof(RegisteredServers));
    using (var writer = new StreamWriter(destinationFile))
    {
        xmlSerializer.Serialize(writer, registeredServers);
    }

    Console.WriteLine("Transformation completed successfully!");
    Console.WriteLine($"Output saved to: {destinationFile}");
    return 0;
}
catch (JsonException ex)
{
    Console.WriteLine($"Error parsing JSON file: {ex.Message}");
    return 1;
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    return 1;
}

static RegisteredServers TransformToSsms22(DataSource source)
{
    var result = new RegisteredServers();
    
    // Create a dictionary to map group IDs to ServerGroup objects
    var groupMap = new Dictionary<string, ServerGroup>();
    
    // First pass: Create all groups
    foreach (var group in source.connectionGroups)
    {
        var serverGroup = new ServerGroup
        {
            Name = group.name,
            Description = group.description
        };
        groupMap[group.id] = serverGroup;
    }
    
    // Second pass: Build hierarchy
    var rootGroups = new List<ServerGroup>();
    foreach (var group in source.connectionGroups)
    {
        var serverGroup = groupMap[group.id];
        
        if (string.IsNullOrEmpty(group.parentId))
        {
            // This is a root group
            rootGroups.Add(serverGroup);
        }
        else if (groupMap.ContainsKey(group.parentId))
        {
            // Add to parent group
            groupMap[group.parentId].SubGroups.Add(serverGroup);
        }
        else
        {
            // Parent not found, add to root
            rootGroups.Add(serverGroup);
        }
    }
    
    result.ServerGroups = rootGroups;
    
    // Third pass: Add connections to their groups
    foreach (var connection in source.connections)
    {
        var registeredServer = new RegisteredServer
        {
            Name = connection.options.connectionName,
            ServerName = connection.options.server,
            Description = $"Database: {connection.options.database}",
            AuthType = MapAuthenticationType(connection.options.authenticationType),
            LoginName = connection.options.user
        };
        
        // Add to the appropriate group
        if (!string.IsNullOrEmpty(connection.groupId) && groupMap.ContainsKey(connection.groupId))
        {
            groupMap[connection.groupId].RegisteredServers.Add(registeredServer);
        }
        else
        {
            // If no group or group not found, create a default root group
            var defaultGroup = rootGroups.FirstOrDefault(g => g.Name == "Imported Connections");
            if (defaultGroup == null)
            {
                defaultGroup = new ServerGroup { Name = "Imported Connections" };
                rootGroups.Add(defaultGroup);
            }
            defaultGroup.RegisteredServers.Add(registeredServer);
        }
    }
    
    return result;
}

static string MapAuthenticationType(string azureAuthType)
{
    // Map Azure Data Studio authentication types to SSMS types
    return azureAuthType?.ToLower() switch
    {
        "integrated" => "Windows Authentication",
        "sqllogin" => "SQL Server Authentication",
        "azuremfa" => "Azure Active Directory - MFA",
        "azureactivedirectory" => "Azure Active Directory - Integrated",
        _ => "SQL Server Authentication"
    };
}
