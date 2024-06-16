using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Xml.Serialization;

namespace ListEmployee;

public class ConnectionSettings : ApplicationSettingsBase
{
    public string ConnectionString
    {
        get => ConnectionBuilder();
    }

    private static string ConnectionBuilder()
    {
        SqlConnectionStringBuilder connection = new();


        XmlSerializer serializer = new XmlSerializer(typeof(ConnectionXml));

        string filepath = Environment.CurrentDirectory + "\\ConnectionString.xml";

        using (FileStream fs = new FileStream(filepath, FileMode.Open))
        {
            ConnectionXml? xml = serializer.Deserialize(fs) as ConnectionXml;

            connection.DataSource = xml.Server;
            connection.InitialCatalog = xml.DateBase;
            connection.UserID = xml.UserId;
            connection.Password = xml.Password;
            connection.IntegratedSecurity = true;
        }


        return connection.ConnectionString;
    }
}

[XmlRoot(ElementName = "ConnectionString")]
public class ConnectionXml
{
    [XmlElement(ElementName = "Server")]
    public string Server;
    [XmlElement(ElementName = "DateBase")]
    public string DateBase;
    [XmlElement(ElementName = "UserId")]
    public string? UserId;
    [XmlElement(ElementName = "Password")]
    public string Password;
    [XmlElement(ElementName = "Trusted_Mode")]
    public string Trusted_Mode;
}
