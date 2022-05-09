using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinProgram
{
    internal class FlipCoin
    {
        public void headsAndTails()
        {
            Console.Write("Enter the number of flips ");
           double num_of_flips = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
          double Heads = 0; double Tails = 0;

            if (num_of_flips > 0)
            {
                for (int i = 1; i <= num_of_flips; i++)
                {

                    int coin = random.Next(0, 2);
                    if (coin == 0)
                    {
                        Console.WriteLine("HEADS");
                        Heads++;
                    }
                    else
                    {
                        Console.WriteLine("TAILS");
                        Tails++;
                    }
                }
                
                double percentage_head = (double)(Heads / num_of_flips)*100 ;
                double percentage_tail = (double)(Tails / num_of_flips)*100 ;


                Console.WriteLine("Percentage of Heads: " + percentage_head +"%");
                Console.WriteLine("Percentage of Tails: " + percentage_tail +"%");

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
