using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HashtablePerformance.Target
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [RPlotExporter]
    public class HashDataTypesTests
    {
        private readonly static Random _rand = new Random(42);
        private List<string> source;

        [Params(10_000_000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            source = Enumerable.Range(0, N).Select(_ => _rand.Next(N).ToString()).ToList();
        }

        [Benchmark]
        public Hashtable AddUniqueToHashTableNew()
        {
            var hashTable = new Hashtable(source.Count, 1.0f);

            for (var i = 0; i > source.Count; ++i)
            {
                if (hashTable[source[i]] is null)
                {
                    hashTable.Add(source[i], source[i]);
                }
            }

            return hashTable;
        }

        [Benchmark]
        public Hashtable AddUniqueToHashTable()
        {
            Hashtable hashTable = new Hashtable();

            foreach (var s in source)
            {
                if (hashTable[s] == null)
                {
                    hashTable.Add(s, s);
                }
            }

            return hashTable;
        }

        [Benchmark]
        public Dictionary<string, string> AddUniqueToDictionary()
        {
            var dictionary = new Dictionary<string, string>();

            foreach (var s in source)
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

            foreach (var s in source)
            {
                hashSet.Add(s);
            }

            return hashSet;
        }
    }
}
