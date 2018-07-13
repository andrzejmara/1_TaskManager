using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace _1_Manager
{
	class Program
	{
		static void Main(string[] args)
		{
			List<TaskModel> tasksList = new List<TaskModel>();

			string command;
			do
			{
				ConsoleEx.WriteLine("Write your command: ", ConsoleColor.Yellow);
				command = Console.ReadLine();
				command = command.Trim().ToLower();


				if (command == "add")
				{


					tasksList.Add(TaskAdder.AddTask());
					Console.WriteLine("Added");


				}
				else if (command == "delete")
				{
					Console.WriteLine();
					Console.WriteLine("Task List:");
					foreach (TaskModel item in tasksList)
					{
						Console.WriteLine($"{tasksList.IndexOf(item)} {item._description}");
					}
					Console.WriteLine();
					Console.WriteLine("Write a number of the Task you want to delete ");
					string deleteThat = Console.ReadLine();
					int deleteThatInt = int.Parse(deleteThat);

					tasksList.RemoveAt(deleteThatInt);
					Console.WriteLine();
					Console.WriteLine("Deleted");
				}
				else if (command == "show")
				{

					Console.WriteLine("Task List:");
					foreach (TaskModel item in tasksList)
					{
						Console.WriteLine($"{tasksList.IndexOf(item)} {item._description}");
					}
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

	}




}
