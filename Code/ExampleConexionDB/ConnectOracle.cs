using Code;

namespace factoryCreator
{
    internal class ConnectOracle : IConnection
    {
        public string Connect()
        {
            return "Connected with Oracle";
        }
    }
}