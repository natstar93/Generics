using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		// Queue: FIFO
		Queue<string> teamMembers = new Queue<string>();
		teamMembers.Enqueue("natalie");
		teamMembers.Enqueue("vitor");
		teamMembers.Enqueue("sree");

		Console.WriteLine(teamMembers.Peek());

		teamMembers.Dequeue();
		Console.WriteLine(teamMembers.Peek());

		teamMembers.Dequeue();
		Console.WriteLine(teamMembers.Peek());

		// Stack: LIFO
		Stack<string> pets = new Stack<string>();
		pets.Push("snail");
		pets.Push("guinea pig");
		pets.Push("dog");

		Console.WriteLine("\nI have {0} pets.", pets.Count);
		Console.WriteLine(pets.Peek());
		
		pets.Pop();
		Console.WriteLine(pets.Peek());
		
		Console.WriteLine("Just moving my {0} to a new cage.", pets.Pop());
		
		Console.WriteLine(pets.Peek());
	}
}