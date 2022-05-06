using System;

namespace FlipCoinProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FLIP COIN AND PRINT PERCENTAGE OF HEADS AND TAILS");
            FlipCoin myobj=new FlipCoin();
            myobj.headsAndTails();
        }
    }
}
