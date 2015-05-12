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
			int _binaryRepresentation_Face =
				(int)cards[0].Number
				& (int)cards[1].Number
				& (int)cards[2].Number
				& (int)cards[3].Number
				& (int)cards[4].Number;
			int _uniqueCardCount = 0;

			for (int _count = 0; _count < 13; _count++ )
			{
				// Check the 1s digit of the binary representation of the poker hand. If it's a 1, that's a unique card
				if ((_binaryRepresentation_Face & 1) == 1)
				{
					_uniqueCardCount++;
				}

				_binaryRepresentation_Face = _binaryRepresentation_Face >> 1;
			}

			return _uniqueCardCount;
		}

		private static bool isFlush(List<Card> cards)
		{
			int _binaryRepresentation_Suit =
				(int)cards[0].Suit
				& (int)cards[1].Suit
				& (int)cards[2].Suit
				& (int)cards[3].Suit
				& (int)cards[4].Suit;
			int _uniqueSuitCount = 0;

			for (int _count = 0; _count < 4; _count++)
			{
				// Check the 1s digit of the binary representation of the poker hand. If it's a 1, that's a unique suit
				if ((_binaryRepresentation_Suit & 1) == 1)
				{
					_uniqueSuitCount++;
				}

				_binaryRepresentation_Suit = _binaryRepresentation_Suit >> 1;
			}

			return (_uniqueSuitCount == 1);
		}

		private static bool isStraight(List<Card> cards)
		{
			throw new NotImplementedException();
		}
	}
}
