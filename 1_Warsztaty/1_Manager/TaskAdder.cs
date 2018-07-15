using System;
using System.Collections.Generic;

namespace _1_Manager
{

	public static class TaskAdder
	{

		public static TaskModel AddTask()
		{
			Console.WriteLine("Add Description: ");
			string description = Console.ReadLine();
			bool? allDay = null;
			bool? important = null;
			DateTime Start = DateTime.Now;
			DateTime End = DateTime.MaxValue;


			do
			{
				Console.WriteLine("Add Start Date in format [year.month.day]: ");
				string startDate = Console.ReadLine();
				Start = DateTime.Parse(startDate);

				Console.WriteLine("This task will take all day to complete? [y/n]");
				string willTakeAllDay = Console.ReadLine();

				if (willTakeAllDay.Trim().ToLower() == "y")
				{
					allDay = true;
					break;

				}
				else if (willTakeAllDay.Trim().ToLower() == "n")
				{

					allDay = false;

					Console.WriteLine("Add End Date in format [year.month.day]: ");
					string endDate = Console.ReadLine();
					End = DateTime.Parse(endDate);
					break;
				}

				else
				{
					Console.WriteLine("Incorrect input");
				}
			} while (!allDay.HasValue);

			do
			{
				Console.WriteLine("Is this task important? [y/n]");
				string isImportant = Console.ReadLine();
				if (isImportant.Trim().ToLower() == "y")
				{
					important = true;
				}
				else if (isImportant.Trim().ToLower() == "n")
				{
					important = false;
				}
				else
				{
					Console.WriteLine("Incorrect input");
				}

			} while (!important.HasValue);



			return new TaskModel(description, Start, End, allDay, important);

		}
	}

}

