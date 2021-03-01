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
    }
}