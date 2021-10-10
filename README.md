Short test to compare performance of HashTable, Dictionary and HashSet

.Net 5 (AMD Ryzen 4800H)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.862 s | 0.0347 s | 0.0325 s |  1,089 MB |
| AddUniqueToDictionary | 2.520 s | 0.0294 s | 0.0246 s |    630 MB |
|    AddUniqueToHashSet | 2.375 s | 0.0219 s | 0.0205 s |    450 MB |

.Net 6 (Intel i7-10700)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.254 s | 0.0329 s | 0.0275 s |  1,089 MB |
| AddUniqueToDictionary | 1.891 s | 0.0345 s | 0.0323 s |    630 MB |
|    AddUniqueToHashSet | 1.203 s | 0.0203 s | 0.0189 s |    450 MB |

.Net 5 (Intel i7-10700)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.623 s | 0.0680 s | 0.0668 s |  1,089 MB |
| AddUniqueToDictionary | 2.048 s | 0.0184 s | 0.0164 s |    630 MB |
|    AddUniqueToHashSet | 1.350 s | 0.0268 s | 0.0385 s |    450 MB |

.Net 3.1 (Intel i7-10700)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.478 s | 0.0203 s | 0.0170 s |  1,089 MB |
| AddUniqueToDictionary | 2.023 s | 0.0184 s | 0.0153 s |    630 MB |
|    AddUniqueToHashSet | 1.832 s | 0.0245 s | 0.0229 s |    450 MB |

.NetFramework 4.8 (Intel i7-10700)
|                Method |    Mean |    Error |   StdDev | Allocated |
|---------------------- |--------:|---------:|---------:|----------:|
|  AddUniqueToHashTable | 3.279 s | 0.0245 s | 0.0229 s |    545 MB |
| AddUniqueToDictionary | 2.119 s | 0.0246 s | 0.0219 s |    450 MB |
|    AddUniqueToHashSet | 1.963 s | 0.0337 s | 0.0282 s |    360 MB |


