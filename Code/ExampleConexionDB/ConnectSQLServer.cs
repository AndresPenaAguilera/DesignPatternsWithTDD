using Code;

namespace factoryCreator
{
    internal class ConnectSQLServer : IConnection
    {
        public string Connect()
        {
            return "Connected with SQL Server";
        }
    }
}