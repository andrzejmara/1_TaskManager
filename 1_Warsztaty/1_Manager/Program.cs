using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace _1_Manager
{
	partial class Program
	{
		static void Main(string[] args)
		{

			string command;
			do
			{
				ConsoleEx.WriteLine("Write your command: ", ConsoleColor.Yellow);
				command = Console.ReadLine();
				command = command.Trim().ToLower();


				if (command == "add")
				{
					TaskAdder.AddTask();
					Console.WriteLine("Added");
				}
				else if (command == "delete")
				{
					Console.WriteLine("Deleted");
				}
				else if (command == "show")
				{
					Console.WriteLine("Showed");
				}
				else if (command == "save")
				{
					Console.WriteLine("Saved");
				}
				else
				{
					Console.WriteLine("Incorrect Command");
				}

				Console.WriteLine();


			} while (command != "exit");
			Console.ReadLine();
		}

		List<TaskModel> taskModels = new List<TaskModel>();
	
}
}
