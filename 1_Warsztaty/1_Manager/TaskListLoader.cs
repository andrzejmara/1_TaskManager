using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _1_Manager
{
	public class TaskListLoader
	{
		public static List<TaskModel> Load(List<TaskModel> tasksList)
		{

		string filePath = $"{Directory.GetCurrentDirectory()}\\Data.csv";

			

			if (File.Exists(filePath))
			{

				List<string> newListOfData = File.ReadAllLines(filePath).ToList();
				foreach (var line in newListOfData)
				{

					string[] entries = line.Split(',');


					if (entries[2] == "")
					{
						tasksList.Add(new TaskModel(entries[0],
							DateTime.ParseExact(entries[1], "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture), null,
							bool.Parse(entries[3]), bool.Parse(entries[4])));
					}
					else if (entries[2] != "")
					{
						tasksList.Add(new TaskModel(entries[0],
							DateTime.ParseExact(entries[1], "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture), DateTime.ParseExact(entries[2], "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture),
							bool.Parse(entries[3]), bool.Parse(entries[4])));
					}





				}
			}
			else
			{
				Console.WriteLine("There is no Data file ;(");
			}

		

			return tasksList;


		}
	}
}