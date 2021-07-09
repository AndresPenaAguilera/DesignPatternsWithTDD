using System;
using System.Collections.Generic;

namespace CodeAbstractFactory.ExampleServicesCompany
{
    public class AbstractFactoryCreator
    {
        private static Dictionary<FactoryTypes, IService> factorysTypes = new Dictionary<FactoryTypes, IService>
        {
            {FactoryTypes.SoftwareDevelopment, new SoftwareDevelopmentService() },
            {FactoryTypes.SoftwareDesing,new SoftwareDesingService()}
        };

        public static IService Create(FactoryTypes factoryTypes)
        {
            IService service;
            if (factorysTypes.TryGetValue(factoryTypes, out service) == false)
            {
                throw new Exception($"The type factiry {factoryTypes} is not implemented");
            }

            return service;
        }

    }
}
