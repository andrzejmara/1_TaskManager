using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1_Manager
{
	
		public class TaskSaver
		{
			public static void TaskSave(List<TaskModel> tasksList)
			{

				string filePath = $"{Directory.GetCurrentDirectory()}\\Data.csv";

				StringBuilder exportData = new StringBuilder();
				foreach (var task in tasksList)
				{
					exportData.AppendLine(task.Export(task));
				}

				File.WriteAllText(filePath,exportData.ToString());

				ConsoleEx.WriteLine("Saved",ConsoleColor.Green);
				
			}
		}
}
