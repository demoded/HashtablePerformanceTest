using BenchmarkDotNet.Running;
using HashtablePerformance.Target;

namespace HashtablePerformanceTest
{
    public static class Program
    {
        public static void Main()
        {
#if RELEASE
            _ = BenchmarkRunner.Run(typeof(HashDataTypesTests).Assembly);
#endif
#if DEBUG
            var test = new HashDataTypesTests();
            var result = test.AddUniqueToHashTableNew();
#endif
        }
    }
}
