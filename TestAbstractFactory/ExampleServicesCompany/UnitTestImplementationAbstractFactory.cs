using CodeAbstractFactory;
using CodeAbstractFactory.ExampleServicesCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAbstractFactory
{
    [TestClass]
    public class UnitTestImplementationAbstractFactory
    {
        [TestMethod]
        public void Should_factoryCreateService_Return_ImplementationWithConcreteTypeFactory1()
        {
            IServicesFactory factory = new SoftwareFactory();
            IService result = factory.CreateService();
            Assert.AreEqual(typeof(SoftwareDevelopmentService), result.GetType());
        }

        [TestMethod]
        public void Should_factoryCreateService_Return_ImplementationWithConcreteTypeFactory2()
        {
            IServicesFactory factory = new DesingFactory();
            IService result = factory.CreateService();
            Assert.AreEqual(typeof(SoftwareDesingService), result.GetType());
        }

        [TestMethod]
        public void Should_assignWork_Return_MessageOfTheImplementationConcreteFactory1()
        {
            IServicesFactory factory = new SoftwareFactory();
            IService result = factory.CreateService();
            Assert.AreEqual("SoftwareDevelopmentService assigned Work", result.assignWork());
        }

        [TestMethod]
        public void Should_assignWork_Return_MessageOfTheImplementationConcreteFactory2()
        {
            IServicesFactory factory = new DesingFactory();
            IService result = factory.CreateService();
            Assert.AreEqual("SoftwareDesingService assigned Work", result.assignWork());
        }

        [TestMethod]
        public void Should_AbstractFactoryCreator_Return_TypeImpementedFactory1()
        {
            string expected = "SoftwareDevelopmentService assigned Work";
            IService service = AbstractFactoryCreator.Create(FactoryTypes.SoftwareDevelopment);
            string actual = service.assignWork();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_AbstractFactoryCreator_Return_TypeImpementedFactory2()
        {
            string expected = "SoftwareDesingService assigned Work";
            IService service = AbstractFactoryCreator.Create(FactoryTypes.SoftwareDesing);
            string actual = service.assignWork();

            Assert.AreEqual(expected, actual);
        }

    }
}
