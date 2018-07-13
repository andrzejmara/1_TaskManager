using System;

namespace _1_Manager
{
	partial class Program
	{
		public static class TaskAdder
		{

			public static void AddTask()
			{
				Console.WriteLine("Add Description: ");
				string description = Console.ReadLine();
				bool? allDay = null;
				bool? important = null;

				do
				{
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
						Console.WriteLine("Add Start Date in format [year.month.day]: ");
						string startDate = Console.ReadLine();
						DateTime Start = DateTime.Parse(startDate);
						Console.WriteLine("Add End Date in format [year.month.day]: ");
						string endDate = Console.ReadLine();
						DateTime End = DateTime.Parse(endDate);
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

					}
					else if (isImportant.Trim().ToLower() == "n")
					{

					}
					else
					{
						Console.WriteLine("Incorrect input");
					}

				} while (!important.HasValue);


			}
		}
	
}
}
