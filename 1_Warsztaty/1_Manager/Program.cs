using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Manager
{
	class Program
	{
		static void Main(string[] args)
		{
			List<TaskModel> tasksList = new List<TaskModel>();

			ConsoleEx.WriteLine("Hi! This is a program that lets you organize your Task List!", ConsoleColor.Green);
			var options = new List<string>() { "add", "delete", "show", "save", "load" };
			ConsoleEx.WriteLine("This is the list of available commands: ",ConsoleColor.Green);
			foreach (var option in options)
			{
				Console.WriteLine(option);
			}
			Console.WriteLine();




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
					// Deletes task from the list
					TaskRemover.Remove(tasksList);

				}
				else if (command == "show")
				{
					//Orders list by importance and date
					var tasksListOrdered = from t in tasksList
										   orderby t._important descending, t._startDate descending
										   select t;
					tasksList = tasksListOrdered.ToList();

					TaskShow.TaskShower(tasksList);

				}
				else if (command == "save")
				{

					TaskSaver.TaskSave(tasksList);


				}
				else if (command == "load")
				{

					tasksList = TaskListLoader.Load(tasksList);

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
