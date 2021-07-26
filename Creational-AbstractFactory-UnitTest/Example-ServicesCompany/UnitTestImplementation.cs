using CodeAbstractFactory;
using CodeAbstractFactory.ExampleServicesCompany;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAbstractFactory
{
    [TestClass]
    public class UnitTestImplementation
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
            string expected = "SoftwareDevelopmentService assigned Work";

            IServicesFactory factory = new SoftwareFactory();

            IService result = factory.CreateService();

            Assert.AreEqual(expected, result.assignWork());
        }

        [TestMethod]
        public void Should_assignWork_Return_MessageOfTheImplementationConcreteFactory2()
        {
            string expected = "SoftwareDesingService assigned Work";

            IServicesFactory factory = new DesingFactory();

            IService result = factory.CreateService();

            Assert.AreEqual(expected, result.assignWork());
        }

        [TestMethod]
        public void Should_AbstractFactoryCreator_Return_TypeImpementedFactory1()
        {
            string expected = "SoftwareDevelopmentService assigned Work";

            IServicesFactory factory = AbstractFactoryCreator.Create(FactoryTypes.SoftwareDevelopment);

            IService service = factory.CreateService();

            string actual = service.assignWork();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_AbstractFactoryCreator_Return_TypeImpementedFactory2()
        {
            string expected = "SoftwareDesingService assigned Work";
            
            IServicesFactory factory = AbstractFactoryCreator.Create(FactoryTypes.SoftwareDesing);

            IService service = factory.CreateService();

            string actual = service.assignWork();

            Assert.AreEqual(expected, actual);
        }

    }
}
