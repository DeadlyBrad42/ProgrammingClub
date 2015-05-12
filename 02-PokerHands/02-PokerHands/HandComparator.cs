using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PokerHands
{
	static class HandComparator
	{
		public static Enums.Winner Compare(List<Card> blackCards, List<Card> whiteCards)
		{
			Enums.Winner _winner = Enums.Winner.Tie;

			Enums.Hand _blackHand = HandRecognizer.Recognize(blackCards);
			Enums.Hand _whiteHand = HandRecognizer.Recognize(whiteCards);

			if(_blackHand > _whiteHand)
			{
				_winner = Enums.Winner.Black;
			}
			else if(_blackHand < _whiteHand)
			{
				_winner = Enums.Winner.White;
			}
			else // Tie
			{
				// Continue comparing based on values
				throw new NotImplementedException();
			}

			return _winner;
		}
	}
}
