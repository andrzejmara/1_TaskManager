using System;
using System.Dynamic;

namespace _1_Manager
{
	public class TaskModel
	{
		public TaskModel(string description, DateTime startDate, DateTime? endDate, bool? wholeDay, bool? important)
		{
			_description = description;
			_startDate = startDate;
			_endDate = endDate;
			_wholeDay = wholeDay;
			_important = important;
		}

		public string _description { get; set; }
		public DateTime _startDate { get; set; }
		public DateTime? _endDate { get; set; }
		public bool? _wholeDay { get; set; }
		public bool? _important { get; set; }



		
		
		
	}
}