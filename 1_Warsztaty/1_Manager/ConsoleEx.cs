using System;

namespace _1_Manager
{

		public static class ConsoleEx
		{
	

			public static void Write(string text, ConsoleColor color)
			{
				
				Console.ForegroundColor = color;
				Console.Write(text);
				Console.ResetColor();
			}

			public static void WriteLine(string text, ConsoleColor color)
			{

				Console.ForegroundColor = color;
				Console.WriteLine(text);
				Console.ResetColor();
			}
		}


}
