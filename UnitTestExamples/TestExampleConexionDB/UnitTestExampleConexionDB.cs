using Code;
using factoryCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestExamples
{
    [TestClass]
    public class UnitTestExampleConexionDB
    {
        [TestMethod]
        public void Should_FactoryCreator_Return_ConnectionWithSQLServer()
        {
            string expected = "Connected with SQL Server";
            IConnection instance = FactoryCreator.Create(Connectiontypes.SQLServer);
            string actual = instance.Connect();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_FactoryCreator_Return_ConnectionWithOracle()
        {
            string expected = "Connected with Oracle";
            IConnection instance = FactoryCreator.Create(Connectiontypes.Oracle);
            string actual = instance.Connect();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_FactoryCreator_Return_ConnectionWithMySQL()
        {
            string expected = "Connected with MySQL";
            IConnection instance = FactoryCreator.Create(Connectiontypes.MySQL);
            string actual = instance.Connect();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_FactoryCreator_Return_ExceptionWhenThereIsNotTypeImplemented()
        {
            string expected = "The type connection Postgresql is not implemented";
            var ex = Assert.ThrowsException<Exception>(() => FactoryCreator.Create(Connectiontypes.Postgresql));
            
            Assert.AreEqual(expected, ex.Message);
        }
    }
}
