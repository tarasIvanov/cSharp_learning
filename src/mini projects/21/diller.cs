using System;

namespace blackJack
{
	public class diller
	{
        Random random = new Random();

        public int sum = 0;

        public void getCard()
        {
            var card = (Pack)(random.Next(2, 11));
            var suit = (Suit)(random.Next(0, 3));

            Game.playedCards[Game.counter, 0] = (int)card;
            Game.playedCards[Game.counter, 1] = (int)suit;
            Game.counter++;

            if ((int)card == 5)
            {
                Game.counter--;

                getCard();
                return;
            }

            if (Game.counter != 1)
            {
                for (int i = 0; i < Game.counter - 1; i++)
                {
                    if (Game.playedCards[i, 0] == (int)card)
                    {
                        if (Game.playedCards[i, 1] == (int)suit)
                        {
                            Game.counter--;

                            getCard();
                            return;
                        }
                    }
                }
            }

            sum += (int)(card);

            Console.WriteLine($"Dillers card is: {card} {suit}({(int)card} points)");
            Console.WriteLine($"Sum of dillers cards is: {sum}");
        }

        
    }
}

