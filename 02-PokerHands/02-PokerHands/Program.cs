using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PokerHands
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch _stopwatch = new Stopwatch();

			//var _lines = File.ReadAllLines("");
			_stopwatch.Start();

			// Read File
			
			// Parse Each line of file
			//List<Card> _blackCards = HandParser.Parse(/*first half of line*/);
			//List<Card> _whiteCards = HandParser.Parse(/*second half of line*/);

			// Compare Hands
			//Enums.Winner _winner = HandComparator.Compare(_blackCards, _whiteCards);

			// Announce Winner
			//switch(_winner)
			//{
			//	case Enums.Winner.Black:
			//		Console.WriteLine("Black wins.");
			//		break;
			//	case Enums.Winner.White:
			//		Console.WriteLine("White wins.");
			//		break;
			//	case Enums.Winner.Tie:
			//		Console.WriteLine("Tie.");
			//		break;
			//}

			_stopwatch.Stop();
			TimeSpan _elapsedTime = _stopwatch.Elapsed;
			string _elapsedTime_s = String.Format(
				"{0:00}h {1:00}m {2:00}s {3:00}ms",
				_elapsedTime.Hours,
				_elapsedTime.Minutes,
				_elapsedTime.Seconds,
				_elapsedTime.Milliseconds / 10
			);
			System.Console.WriteLine("Elapsed time: " + _elapsedTime_s);
			System.Console.ReadKey();
		}
	}
}
