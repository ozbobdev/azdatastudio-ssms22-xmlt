using System.Xml.Serialization;

namespace AzDataStudioToSsms22;

// Destination XML schema for SSMS 22 registered servers
[XmlRoot("RegisteredServers")]
public class RegisteredServers
{
    [XmlElement("ServerGroup")]
    public List<ServerGroup> ServerGroups { get; set; } = new();
}

[XmlType("ServerGroup")]
public class ServerGroup
{
    [XmlAttribute("name")]
    public string Name { get; set; } = string.Empty;

    [XmlAttribute("description")]
    public string? Description { get; set; }

    [XmlElement("ServerGroup")]
    public List<ServerGroup> SubGroups { get; set; } = new();

    [XmlElement("RegisteredServer")]
    public List<RegisteredServer> RegisteredServers { get; set; } = new();
}

[XmlType("RegisteredServer")]
public class RegisteredServer
{
    [XmlAttribute("name")]
    public string Name { get; set; } = string.Empty;

    [XmlAttribute("serverName")]
    public string ServerName { get; set; } = string.Empty;

    [XmlAttribute("description")]
    public string? Description { get; set; }

    [XmlAttribute("connectionString")]
    public string? ConnectionString { get; set; }

    [XmlAttribute("serverType")]
    public string ServerType { get; set; } = "DatabaseEngine";

    [XmlAttribute("authType")]
    public string AuthType { get; set; } = string.Empty;

    [XmlAttribute("loginName")]
    public string? LoginName { get; set; }
}
