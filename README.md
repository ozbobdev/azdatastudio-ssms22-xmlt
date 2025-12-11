# Azure Data Studio to SSMS22 Connection Transformer

Transform the JSON from exported Azure Data Studio connections into SSMS22 XML format. Passwords must be entered manually in SSMS after import.

## Description

This .NET console application reads Azure Data Studio connection data from a JSON file and transforms it into SSMS 22 RegisteredServers XML format. The tool preserves:
- Connection groups and their hierarchical structure
- Connection details (server names, databases, authentication types)
- Group descriptions and metadata

## Requirements

- .NET 8.0 or later

## Building

```bash
cd AzDataStudioToSsms22
dotnet build
```

## Usage

```bash
dotnet run <source.json> [destination.xml]
```

Arguments:
- `source.json`: Path to the Azure Data Studio connections JSON file (required)
- `destination.xml`: Path to the output SSMS22 XML file (optional, defaults to output.xml)

### Example

```bash
dotnet run sample-source.json output.xml
```

## Source JSON Schema

The application expects JSON with the following structure:

```json
{
  "connectionGroups": [
    {
      "name": "string",
      "id": "string",
      "parentId": "string|null",
      "color": "string (optional)",
      "description": "string (optional)"
    }
  ],
  "connections": [
    {
      "groupId": "string",
      "providerName": "string",
      "savePassword": "boolean",
      "id": "string",
      "options": {
        "connectionName": "string",
        "server": "string",
        "database": "string",
        "authenticationType": "string",
        "user": "string (optional)",
        "applicationName": "string (optional)",
        "connectTimeout": "number (optional)",
        "originalDatabase": "string (optional)",
        "groupId": "string (optional)",
        "databaseDisplayName": "string (optional)"
      }
    }
  ]
}
```

## Output XML Format

The application generates SSMS 22 RegisteredServers XML format using a template-based approach:

1. Transforms Azure Data Studio connections to RegisteredServers XML structure
2. Loads `template.xml` with placeholders
3. Replaces `{{uuid}}` with a new GUID
4. Replaces `{{RegisteredServers:bufferData}}` with the serialized RegisteredServers XML
5. Saves the final output

The output includes:
- Hierarchical server groups
- Registered servers with connection details
- Proper authentication type mappings
- Unique UUID for the registration set

## Authentication Type Mapping

- `integrated` → Windows Authentication
- `sqllogin` → SQL Server Authentication
- `azuremfa` → Azure Active Directory - MFA
- `azureactivedirectory` → Azure Active Directory - Integrated
- Other types → SQL Server Authentication (default)

## Files

- `Program.cs` - Main application with transformation logic
- `SourceModels.cs` - Azure Data Studio JSON schema classes
- `destination.cs` - SSMS22 XML schema classes
- `template.xml` - XML template with placeholders for SSMS22 format
- `sample-source.json` - Example input data
- `sample-output.xml` - Example output showing transformation

## Notes

- Passwords are not included in the transformation and must be entered manually in SSMS
- Connections without a valid group are placed in an "Imported Connections" group
- The tool preserves the hierarchical structure of connection groups
- The `template.xml` file must be present in the application directory or the same directory as the source file
