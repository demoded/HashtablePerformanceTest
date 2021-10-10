Short test to compare performance of HashTable, Dictionary and HashSet

.Net 5 (AMD Ryzen 4800H)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.862 s | 0.0347 s | 0.0325 s |  1,089 MB |
| AddUniqueToDictionary | 2.520 s | 0.0294 s | 0.0246 s |    630 MB |
|    AddUniqueToHashSet | 2.375 s | 0.0219 s | 0.0205 s |    450 MB |

.Net 5 (Intel i7-10700)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.403 s | 0.0059 s | 0.0052 s |  1,089 MB |
| AddUniqueToDictionary | 1.920 s | 0.0192 s | 0.0170 s |    630 MB |
|    AddUniqueToHashSet | 1.780 s | 0.0299 s | 0.0280 s |    450 MB |

.NetFramework 4.8
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.116 s | 0.0324 s | 0.0288 s |    545 MB |
| AddUniqueToDictionary | 1.968 s | 0.0247 s | 0.0219 s |    450 MB |
|    AddUniqueToHashSet | 1.944 s | 0.0359 s | 0.0353 s |    360 MB |


