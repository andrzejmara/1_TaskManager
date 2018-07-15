using System;
using System.Collections.Generic;

namespace _1_Manager
{
	public class TaskRemover
	{
		public static void Remove(List<TaskModel> tasksList)
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

	}
}