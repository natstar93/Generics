using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		List<string> teamMembers = new List<string>();
		teamMembers.Add("natalie");
		teamMembers.Add("vitor");
		teamMembers.Add("sree");
		foreach (string teamMember in teamMembers)
		{
			Console.WriteLine("{0} is awesome", teamMember);
		}

		string teamMembersString = "Identity Team members: ";
		for (int i = 0; i < teamMembers.Count; i++)
		{
			teamMembersString = teamMembersString + teamMembers[i] + (i + 1 < teamMembers.Count ? ", " : ".\n");
		}

		Console.WriteLine(teamMembersString);
		List<string> additionalTeamMembers = new List<string>();
		additionalTeamMembers.Add("rodrigo");
		additionalTeamMembers.Add("andy");
		additionalTeamMembers.Add("guilherme");
		teamMembers.AddRange(additionalTeamMembers);
		int counter = 0;
		do
		{
			Console.WriteLine("{0} has joined the standup", teamMembers[counter]);
			counter++;
		}
		while (counter < teamMembers.Count);
		
		Console.WriteLine("***");
		
		int whileCounter = 0;
		while (whileCounter < teamMembers.Count)
		{
			Console.WriteLine("{0} has left the standup", teamMembers[whileCounter]);
			whileCounter++;
		}
		
		Console.WriteLine("**");
		
		int a = 1, b = 1;
		
		Console.WriteLine("do while: ");
		do {
			Console.WriteLine(a);
			a++;
		}
		while (a == 100);
		
		Console.WriteLine("\nwhile: ");
		while (b == 100)
		{
			Console.WriteLine(b);
			b++;
		}
		Console.WriteLine($"\na is {a}, b is {b}");
	}
}