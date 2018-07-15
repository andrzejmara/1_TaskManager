using System;
using System.Collections.Generic;

namespace _1_Manager
{

		public class TaskShow
		{
			public static void TaskShower(List<TaskModel> tasksList)
			{
				Console.WriteLine("Task List:");

				ConsoleEx.Write("Description |".PadLeft(15),ConsoleColor.DarkCyan);
				ConsoleEx.Write("Start Date |".PadLeft(25),ConsoleColor.DarkCyan);
				ConsoleEx.Write("Importance".PadLeft(20),ConsoleColor.DarkCyan);
				Console.WriteLine();
				Console.WriteLine("".PadLeft(60,'_'));



				foreach (TaskModel item in tasksList)
				{
					Console.WriteLine();
					ConsoleEx.Write($"{item._description} |".PadLeft(15),ConsoleColor.Cyan);
					ConsoleEx.Write($"{item._startDate} |".PadLeft(25),ConsoleColor.Magenta);

				if (item._important.HasValue && item._important == true)
					{
						ConsoleEx.Write(" Important!".PadLeft(20), ConsoleColor.Red);
					}
				}

				Console.WriteLine();
				
			}
		}

}
