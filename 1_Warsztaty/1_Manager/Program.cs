using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
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
					//tasksList = tasksList.OrderBy(date => date._startDate).ToList();


					var tasksListOrdered = from t in tasksList
										   orderby t._important, t._startDate descending
										   select t;
					tasksList = tasksListOrdered.ToList();


					Console.WriteLine("Added");


				}
				else if (command == "delete")
				{

					TaskRemover.Remove(tasksList);

				}
				else if (command == "show")
				{

					Console.WriteLine("Task List:");



					foreach (TaskModel item in tasksList)
					{

						Console.WriteLine($"{item._description} - {item._startDate}");
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
