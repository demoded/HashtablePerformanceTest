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
            test.Setup();
            var result = test.AddUniqueToHashTableLessMemory();
            var result2 = test.AddUniqueToHashTable();
            System.Console.WriteLine(result.Count == result2.Count);
            for (var i = 0; i < result2.Count; i++)
            {
                if (result[i] != result2[i]) throw new System.Exception("mismach!");
            }

            var dicResult = test.AddUniqueToDictionaryLessMemory();
            var dicResult2 = test.AddUniqueToDictionary();
            System.Console.WriteLine(dicResult.Count == dicResult2.Count);
            for (var i = 0; i < test.Source.Count; i++)
            {
                if (dicResult[test.Source[i]] != dicResult2[test.Source[i]]) throw new System.Exception("mismach!");
            }
#endif
        }
    }
}
