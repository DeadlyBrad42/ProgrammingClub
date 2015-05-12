using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _02_PokerHands
{
	class Program
	{
		public const int TimesToRun = 3;
		public const string FilePath = "";

		static void Main(string[] args)
		{
			List<Stopwatch> _runTimers = new List<Stopwatch>(TimesToRun);

			for (int _runCount = 0; _runCount < TimesToRun; _runCount++)
			{
				//var _lines = File.ReadAllLines(FilePath);
				_runTimers.ElementAt(_runCount).Start();

				// Read File

				//foreach(/*line of file*/)
				//{
				//	 Parse Each line of file
				//	List<Card> _blackCards = HandParser.Parse(/*first half of line*/);
				//	List<Card> _whiteCards = HandParser.Parse(/*second half of line*/);

				//	 Compare Hands
				//	Enums.Winner _winner = HandComparator.Compare(_blackCards, _whiteCards);

				//	 Announce Winner
				//	switch(_winner)
				//	{
				//		case Enums.Winner.Black:
				//			Console.WriteLine("Black wins.");
				//			break;
				//		case Enums.Winner.White:
				//			Console.WriteLine("White wins.");
				//			break;
				//		case Enums.Winner.Tie:
				//			Console.WriteLine("Tie.");
				//			break;
				//	}
				//}

				_runTimers.ElementAt(_runCount).Stop();
				
			}

			Console.WriteLine("=== Run Times ==================================================================");
			// Times per run
			for (int _runCount = 0; _runCount < TimesToRun; _runCount++)
			{
				Stopwatch _stopwatch = _runTimers.ElementAt(_runCount);
				Console.WriteLine("Run " + (_runCount + 1) + " elapsed time: " + FormatTimeSpan(_stopwatch.Elapsed));
			}
			Console.WriteLine();
			// Average run time
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
				timespan.Milliseconds / 10
			);
		}
	}
}
