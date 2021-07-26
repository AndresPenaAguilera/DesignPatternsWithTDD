using System;
using System.Collections.Generic;

namespace CodeAbstractFactory.ExampleServicesCompany
{
    public class AbstractFactoryCreator
    {
        private static Dictionary<FactoryTypes, IServicesFactory> factorysTypes = new Dictionary<FactoryTypes, IServicesFactory>
        {
            {FactoryTypes.SoftwareDevelopment, new SoftwareFactory() },
            {FactoryTypes.SoftwareDesing,new DesingFactory()}
        };

        public static IServicesFactory Create(FactoryTypes factoryTypes)
        {
            IServicesFactory service;
            if (factorysTypes.TryGetValue(factoryTypes, out service) == false)
            {
                throw new Exception($"The type factiry {factoryTypes} is not implemented");
            }

            return service;
        }

    }
}
