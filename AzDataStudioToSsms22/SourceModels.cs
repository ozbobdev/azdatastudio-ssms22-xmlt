namespace AzDataStudioToSsms22;

// Source JSON schema for Azure Data Studio connections
public class DataSource
{
    public List<ConnectionGroup> connectionGroups { get; set; } = new();
    public List<Connection> connections { get; set; } = new();
}

public class ConnectionGroup
{
    public string name { get; set; } = string.Empty;
    public string id { get; set; } = string.Empty;
    public string? parentId { get; set; }
    public string? color { get; set; }
    public string? description { get; set; }
}

public class Connection
{
    public string groupId { get; set; } = string.Empty;
    public string providerName { get; set; } = string.Empty;
    public bool savePassword { get; set; }
    public string id { get; set; } = string.Empty;
    public ConnectionOptions options { get; set; } = new();
}

public class ConnectionOptions
{
    public string connectionName { get; set; } = string.Empty;
    public string server { get; set; } = string.Empty;
    public string database { get; set; } = string.Empty;
    public string authenticationType { get; set; } = string.Empty;
    public string? user { get; set; }
    public string? applicationName { get; set; }
    public int? connectTimeout { get; set; }
    public string? originalDatabase { get; set; }
    public string? groupId { get; set; }
    public string? databaseDisplayName { get; set; }
}
