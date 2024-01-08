// Hash table class
// Array for storage
// Hashing algorithm + storage
// Retrieval
// Collision resolution

using System;

public class HashTable
{
    private int[] array = new int[10];

    public HashTable() 
    {

    }

    public bool StoreData(double retailPrice, int wordCount)
    {
        int index = Hash(retailPrice, wordCount);
        array[index] = wordCount;
        return true;
    }

    public void PrintTable()
    {
        foreach(int i in array)
        {
            Console.WriteLine(i);
        }
    }

    public int Hash(double retailPrice, int wordCount)
    {
       double index = wordCount / retailPrice;

       double index2 = index % 10;

       int i = (int)Math.Floor(index2);

       return i;
    }
}