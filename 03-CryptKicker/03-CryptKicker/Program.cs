using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace _03_CryptKicker
{
	class Program
	{
		public const int TimesToRun = 3;
		public const string FilePath = @"input3.txt";
		public const bool LoggingEnabled = true;

		static void Main(string[] args)
		{
			List<Stopwatch> _runTimers = new List<Stopwatch>();

			for (int _runCount = 0; _runCount < TimesToRun; _runCount++)
			{
				// Read file into memory
				string[] _lines = File.ReadAllLines(FilePath);

				// Initialize & start stopwatch
				Stopwatch _stopwatch = new Stopwatch();
				_stopwatch.Start();

				// Print run information
				if (LoggingEnabled)
				{
					Console.WriteLine("Run #" + (_runCount + 1));
				}

				// stuff here
				

				// Stop the timer and store it
				_stopwatch.Stop();
				_runTimers.Add(_stopwatch);

				// Print run information
				if (LoggingEnabled)
				{
					//Console.WriteLine("Black wins: " + _blackCount + ", White wins: " + _whiteCount + ", Ties: " + _tieCount);
					Console.WriteLine("Run " + (_runCount + 1) + " elapsed time: " + FormatTimeSpan(_stopwatch.Elapsed));
				}
			}

			// Average run time
			Console.WriteLine();
			TimeSpan _averageRunTime = TimeSpan.FromMilliseconds(_runTimers.Average(x => x.Elapsed.TotalMilliseconds));
			Console.WriteLine("Average run time: " + FormatTimeSpan(_averageRunTime));
			Console.WriteLine();

			// Bye
			System.Console.ReadKey();
		}

		private static string FormatTimeSpan(TimeSpan timespan)
		{
			return String.Format(
				"{0:00}h {1:00}m {2:00}s {3:00}ms",
				timespan.Hours,
				timespan.Minutes,
				timespan.Seconds,
				timespan.Milliseconds
			);
		}
	}
}
