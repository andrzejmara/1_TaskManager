using System;
using System.Dynamic;

namespace _1_Manager
{
	public class TaskModel
	{
		private string _description { get; set; }
		private DateTime _startDate { get; set; }
		private DateTime? _endDate { get; set; }
		private bool? _wholeDay { get; set; }
		//jeśli flaga _wholeDay jest true - to nie potrzeba brać _startDate
		private bool? _important { get; set; }




		public TaskModel(string description, DateTime startDate)
		{
			
			_description = description;
			_startDate = startDate;
			

		}
	}
}