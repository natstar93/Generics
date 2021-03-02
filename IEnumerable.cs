using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        IEnumerable<int> idNumbers = new[] { 123, 124, 125, 1001, 1002 };
        Console.WriteLine(idNumbers.First());

        IEnumerable<string> recentIdNos =
            from idNum in idNumbers
            where idNum >= 1000
            orderby idNum
            select idNum;
    }
}