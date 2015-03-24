using System;
using System.Collections.Generic;

namespace AustralianVoting
{
	class Driver
	{
		const string _path = @"input.txt";

		static void Main(string[] args)
		{
			List<BallotSet> _ballotSets = new List<BallotSet>();

			// Read input file into memory
			_ballotSets = FileReader.ProcessFile(_path);

			// Foreach ballotset in memory
			foreach (BallotSet _ballotSet in _ballotSets)
			{
				bool _somebodyHasWon = false;
				
				// Keep calculating until there's a clear winner
				while(!_somebodyHasWon)
				{
					KeyValuePair<int, int> _weakestCandidate = new KeyValuePair<int, int>(0, 100);
					KeyValuePair<int, int> _winningCandidate = new KeyValuePair<int,int>();

					// Tally the votes
					Dictionary<int, int> _currentTally = _ballotSet.Tally();
					foreach (KeyValuePair<int, int> _candidate in _currentTally)
					{
						// Look for a winning candidate
						if (_candidate.Value > 50)
						{
							// this candidate has won!
							_winningCandidate = _candidate;
							_somebodyHasWon = true;
							break;
						}
						// ... And also find the weakest candidate, in case there's no clear winner
						if (_candidate.Value < _weakestCandidate.Value && !_ballotSet.EleminatedCandidates.Contains(_candidate.Key))
						{
							// update the weakest candidate
							_weakestCandidate = _candidate;
						}
					}

					if(_somebodyHasWon)
					{
						// return name and show congratulations!
						Console.WriteLine("Winner: " + _ballotSet.Candidates[_winningCandidate.Key - 1]);		// -1 because I used a 1-based index, instead of 0
					}
					else
					{
						// Eliminate the weakest candidate this round
						_ballotSet.EleminatedCandidates.Add(_weakestCandidate.Key);

						// Go through Ballots and delete? eliminated votes
						_ballotSet.ProcessEliminatedCandidates();
					}
				}
			}

			System.Console.ReadKey();
		}
	}
}
