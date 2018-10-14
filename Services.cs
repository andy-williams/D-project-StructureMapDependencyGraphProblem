using System;

namespace StructureMapDependencyGraph
{
    public class AService : IAService
    {
        public AService()
        {
            Console.WriteLine("**** A SERVICE ****");
        }

        public void ADoSomething()
        {
            Console.WriteLine("ADoSomething");
        }
    }

    public interface IAService
    {
        void ADoSomething();
    }

    public class BService : IBService
    {
        private readonly IAService _aService;

        public BService(IAService aService)
        {
            Console.WriteLine("**** B SERVICE ****");
            _aService = aService;
        }

        public void BDoSomething()
        {
            Console.WriteLine("BDoSomething");
        }
    }

    public interface IBService
    {
        void BDoSomething();
    }
}
