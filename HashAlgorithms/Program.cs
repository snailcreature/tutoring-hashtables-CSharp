// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Book data:
//  - Title
//  - Author
//  - Publisher
//  - RRP
//  - Word count
// Hashing key = word count and RRP
// Collision resolution: Bruteforce

HashTable hashTable = new HashTable();

hashTable.StoreData(24.99, 10000);

hashTable.PrintTable();