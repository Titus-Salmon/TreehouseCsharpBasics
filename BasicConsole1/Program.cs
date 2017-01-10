using System;

namespace BasicConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int runningTotal = 0;
			bool keepGoing = true;

			while (keepGoing)
			{ 
				//prompt for minutes exercised
				Console.Write("Enter minutes of whatever, or type \"quit\" to exit: ");

				string entry = Console.ReadLine();

				if (entry == "quit")
				{
					keepGoing = false;
				}
				else
				{
					int minutes = int.Parse(entry);
					runningTotal = runningTotal + minutes;


					//add minites to running total


					//display total minutes
					Console.WriteLine("you've entered " + runningTotal + " total minutes");


					//repeat until quit
				}
				Console.Write("Goodbye");
			}
		}
	}
}