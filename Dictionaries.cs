using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		// Add(TKey, TValue)
		Dictionary<string, string> locations = new Dictionary<string, string>();
		locations.Add("LDN", "London");
		locations.Add("EDI", "Edinburgh");
		locations.Add("MAN", "Manchester");
		locations.Add("NEW", "Newcastle");
		try
		{
			locations.Add("LDN", "Lon");
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.ToString());
		}

		// Get a value
		Console.WriteLine(locations["LDN"]);
		string locationValue = "";
		locations.TryGetValue("LDN", out locationValue);
		Console.WriteLine(locationValue);
		// Remove a KV pair with Remove(TKey)
		locations.Remove("LDN");
		if (locations.TryGetValue("LDN", out locationValue))
		{
			Console.WriteLine(locationValue);
		}
		else
		{
			Console.WriteLine("Key \"LDN\" not found.");
			Console.WriteLine($"The value of locationValue is now: {locationValue}.");
		}

		// Remove a value with Remove(Tkey, TValue)
		locations.Remove("EDI", out locationValue);
		Console.WriteLine($"The value of locationValue is now: {locationValue}.");
		// Check whether keys are in the Dictionary
		List<string> testKeys = new List<string>{"MAN", "LIV", "CAR"};
		foreach (string testKey in testKeys)
		{
			Console.WriteLine($"Locations dictionary contains key {testKey}: {locations.ContainsKey(testKey)}");
		}

		//Get the values as a ValueCollection
		Dictionary<string, string>.ValueCollection values = locations.Values;
		Console.WriteLine($"Number of values: {values.Count}.");
		foreach (string value in values)
		{
			Console.WriteLine($"Value in ValueCollection: {value}"); // Q: Is there a way of printing an index? Wasn't sure how to do this with a for loop. Going to read about enumerators, maybe that will help	  
		}
		
	}
}