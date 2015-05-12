using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_PokerHands;

namespace _02_PokerHands
{
	static class HandRecognizer
	{
		public static Enums.Hand Recognize(List<Card> cards)
		{
			int _uniqueCards = getUniqueCardCount(cards);

			Enums.Hand _hand = Enums.Hand.HighCard;

			switch(_uniqueCards)
			{
				case 5:
					// Five unique cards narrows it down to either HighCard, Straight, Flush, or StraightFlush
					bool _isFlush = isFlush(cards);
					bool _isStraight = isStraight(cards);

					if(_isStraight && _isFlush)
					{
						_hand = Enums.Hand.StraightFlush;
					}
					else if (_isStraight && !_isFlush)
					{
						_hand = Enums.Hand.Straight;
					}
					else if (!_isStraight && _isFlush)
					{
						_hand = Enums.Hand.Flush;
					}
					else
					{
						_hand = Enums.Hand.HighCard;
					}
					break;
				case 4:
					// Four unique cards narrows it down to a Pair
					_hand = Enums.Hand.Pair;
					break;
				case 3:
					// Three unique cards narrows it down to TwoPair or ThreeOfAKind
					break;
				case 2:
					// Two unique cards narrows it down to either a FullHouse or FourOfAKind
					break;
			}

			return _hand;
		}

		private static int getUniqueCardCount(List<Card> cards)
		{
			int _faceValuesBinary =
				(int)cards[0].Number
				& (int)cards[1].Number
				& (int)cards[2].Number
				& (int)cards[3].Number
				& (int)cards[4].Number;
			int _uniqueFaceValueCount = 0;

			for (int _faceCount = 0; _faceCount < 13; _faceCount++ )
			{
				// Check the 1s digit of the binary representation of the poker hand's values. If it's a 1, that's a unique card
				if ((_faceValuesBinary & 1) == 1)
				{
					_uniqueFaceValueCount++;
				}

				_faceValuesBinary = _faceValuesBinary >> 1;
			}

			return _uniqueFaceValueCount;
		}

		private static int getUniqueSuitCount(List<Card> cards)
		{
			int _SuitsBinary =
				(int)cards[0].Suit
				& (int)cards[1].Suit
				& (int)cards[2].Suit
				& (int)cards[3].Suit
				& (int)cards[4].Suit;
			int _uniqueSuitCount = 0;

			for (int _suitCount = 0; _suitCount < 4; _suitCount++)
			{
				// Check the 1s digit of the binary representation of the poker hand's suits. If it's a 1, that's a unique suit
				if ((_SuitsBinary & 1) == 1)
				{
					_uniqueSuitCount++;
				}

				_SuitsBinary = _SuitsBinary >> 1;
			}

			return _uniqueSuitCount;
		}

		private static bool isFlush(List<Card> cards)
		{
			return (getUniqueSuitCount(cards) == 1);
		}

		private static bool isStraight(List<Card> cards)
		{
			throw new NotImplementedException();
		}
	}
}
