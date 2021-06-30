using Code;

namespace factoryCreator
{
    internal class ConnectMySQL : IConnection
    {
        public string Connect()
        {
            return "Connected with MySQL";
        }
    }
}