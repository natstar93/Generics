using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        HashSet<string> doges = new HashSet<string> { "westie", "fluffy", "sausage" };

        Console.WriteLine(doges.Contains("westie"));
        Console.WriteLine(doges.Contains("scottie"));

        doges.Add("sausage");
        // can't add something that's aleady there

        Console.WriteLine("******");

        foreach(string doge in doges) {
            Console.WriteLine(doge);
        }

        string[] dogs = new string[] { "beagle", "fluffy", "westie" };
        doges.IntersectWith(dogs);
		
		Console.WriteLine("\nDoges intersected with dogs: ");
		foreach(string doge in doges) {
            Console.WriteLine(doge);
        }
		
		string[] cats = new string[] { "bitey", "stinky" };
		
		doges.UnionWith(cats);
		
		Console.WriteLine("\nDoges union with cats: ");
		foreach(string doge in doges) {
            Console.WriteLine(doge);
        }
    }
}