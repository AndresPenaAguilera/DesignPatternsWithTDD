using System;

namespace CodeAbstractFactory
{
    [Serializable]
    public class SoftwareDevelopmentService : IService
    {
        public string assignWork()
        {
            return "SoftwareDevelopmentService assigned Work";
        }

        public string deliverDate()
        {
            return "SoftwareDevelopmentService with delivery date";
        }
    }
}