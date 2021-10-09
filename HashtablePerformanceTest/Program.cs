using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HashtablePerformanceTest
{
    [MemoryDiagnoser]
    public class HashDataTypes
    {

        private static Random _rand = new Random(1);
        List<string> source = Enumerable.Range(0, 10000000).Select(i => _rand.Next(100000000).ToString()).ToList();

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
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

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
            HashSet<string> hashSet = new HashSet<string>();

            foreach (var s in source)
            {
                if (!hashSet.Contains(s))
                {
                    hashSet.Add(s);
                }
            }

            return hashSet;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);

            //var run = new HashDataTypes();
            //var a = run.AddUniqueToHashTable();
            //var b = run.AddUniqueToDictionary();
            //var c = run.AddUniqueToHashSet();
        }
    }
}
