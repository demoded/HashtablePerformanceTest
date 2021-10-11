using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashtablePerformance.Target
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [RPlotExporter]
    public class HashDataTypesTests
    {
        private readonly static Random _rand = new Random(42);
        public List<string> Source;

        [Params(10_000_000)]
        public int N = 10_000_000;

        [GlobalSetup]
        public void Setup()
        {
            Source = Enumerable.Range(0, N).Select(_ => _rand.Next(N).ToString()).ToList();
        }

        [Benchmark]
        public Hashtable AddUniqueToHashTable()
        {
            Hashtable hashTable = new Hashtable();

            foreach (var s in Source)
            {
                if (hashTable[s] == null)
                {
                    hashTable.Add(s, s);
                }
            }

            return hashTable;
        }

        [Benchmark]
        public Hashtable AddUniqueToHashTableLessMemory()
        {
            var hashTable = new Hashtable(Source.Count, 1.0f);

            foreach (var s in Source)
            {
                if (hashTable[s] == null)
                {
                    hashTable.Add(s, s);
                }
            }

            return hashTable;
        }

        [Benchmark]
        public Dictionary<string, string> AddUniqueToDictionaryLessMemory()
        {
            var dictionary = new Dictionary<string, string>(Source.Count);

            foreach (var s in Source)
            {
                if (!dictionary.ContainsKey(s))
                {
                    dictionary.Add(s, s);
                }
            }

            return dictionary;
        }

        [Benchmark]
        public Dictionary<string, string> AddUniqueToDictionary()
        {
            var dictionary = new Dictionary<string, string>();

            foreach (var s in Source)
            {
                if (!dictionary.ContainsKey(s))
                {
                    dictionary.Add(s, s);
                }
            }

            return dictionary;
        }

        [Benchmark]
        public HashSet<string> AddUniqueToHashSet()
        {
            var hashSet = new HashSet<string>();

            foreach (var s in Source)
            {
                hashSet.Add(s);
            }

            return hashSet;
        }
    }
}
