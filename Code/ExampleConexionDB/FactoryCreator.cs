using Code;
using System;
using System.Collections.Generic;

namespace factoryCreator
{
    public class FactoryCreator
    {

        private static Dictionary<Connectiontypes, IConnection> ConnectionsTypes = new Dictionary<Connectiontypes, IConnection>
        {
            {Connectiontypes.SQLServer, new ConnectSQLServer() },
            {Connectiontypes.Oracle,new ConnectOracle()},
            {Connectiontypes.MySQL,new ConnectMySQL()}
        };

        public static IConnection Create(Connectiontypes Connectiontypes)
        {
            IConnection connection;
            
            if (ConnectionsTypes.TryGetValue(Connectiontypes, out connection) == false)
            {
                throw new Exception($"The type connection {Connectiontypes} is not implemented");
            }

            ConnectionsTypes.TryGetValue(Connectiontypes, out connection);

            return connection;
        }
    }
}