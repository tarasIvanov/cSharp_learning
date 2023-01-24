using System;
using System.Linq;
using System.Globalization;
using Bogus;

namespace blackJack
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool res = true;

            player player = new player();
            diller diller = new diller();


            Console.WriteLine("Welcome to the game of blackjack!!");
            Console.WriteLine("Let's play!!\n");


            while (res)
            {
                player.getCard();
                res = player.isPlayContinue();
            }

            
            if (player.sum <= 21)
            {
                Console.WriteLine("\nNow play diller!");

                while (diller.sum < player.sum)
                {
                    diller.getCard();

                    if (diller.sum > player.sum)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (diller.sum > 21)
                {
                    Console.WriteLine("You won)!\nCongratulattions!!!!");
                }
                else if (diller.sum == player.sum)
                {
                    Console.WriteLine("draw)");
                } else if(diller.sum < player.sum)
                {
                    Console.WriteLine("You won)!\nCongratulattions!!!!");
                }
                else if (diller.sum > player.sum)
                {
                    Console.WriteLine("Diller has more points than you( \nGame over!");
                }
            }


        }

    }

}






