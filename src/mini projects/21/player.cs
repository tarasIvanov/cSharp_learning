using System;

namespace blackJack
{
    class player
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

            Console.WriteLine($"Your card is: {card} {suit}({(int)card} points)");
            Console.WriteLine($"Sum of your cards is: {sum}");
        }


        public bool isPlayContinue()
        {
            bool res = false;
            char menu;

            if (sum > 21)
            {
                Console.WriteLine("Your sum is bigger than 21\nGame over!");
            }
            else if (sum == 21)
            {
                Console.WriteLine("You have 21 point, you can't take more card");
            }
            else
            {
                Console.WriteLine("Do you want one more card Y/N ?");
                menu = Convert.ToChar(Console.ReadLine());

                switch (menu)
                {
                    case 'Y':
                        res = true;
                        break;
                    case 'y':
                        res = true;
                        break;
                    case 'N':
                        res = false;
                        break;
                    case 'n':
                        res = false;
                        break;

                    default:
                        Console.WriteLine("Enter Y/N");
                        res = isPlayContinue();
                        break;
                }

            }

            return res;
        }



    }
}

