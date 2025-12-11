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

The application generates SSMS 22 RegisteredServers XML format with:
- Hierarchical server groups
- Registered servers with connection details
- Proper authentication type mappings

## Authentication Type Mapping

- `integrated` → Windows Authentication
- `sqllogin` → SQL Server Authentication
- `azuremfa` → Azure Active Directory - MFA
- `azureactivedirectory` → Azure Active Directory - Integrated
- Other types → SQL Server Authentication (default)

## Notes

- Passwords are not included in the transformation and must be entered manually in SSMS
- Connections without a valid group are placed in an "Imported Connections" group
- The tool preserves the hierarchical structure of connection groups
