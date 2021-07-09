namespace CodeAbstractFactory
{
    public class DesingFactory : IServicesFactory
    {
        public IService CreateService()
        {
            return new SoftwareDesingService();
        }
    }
}