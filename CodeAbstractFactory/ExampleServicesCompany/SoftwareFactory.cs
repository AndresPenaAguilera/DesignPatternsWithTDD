namespace CodeAbstractFactory
{
    public class SoftwareFactory : IServicesFactory
    {
        public IService CreateService()
        {
            return new SoftwareDevelopmentService();
        }
    }
}