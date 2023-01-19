//Josh Bello
// Mission 2

using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            int throws = 0;
            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
            throws = Int32.Parse(Console.ReadLine());

            //declare variables
            var rand = new Random();
            int i;
            int both = 0;
            int[] counts = new int[11];
            int starsCount;
            string stars;

            //Simulate 2 Dice and update count for number rolled
            for (i = 0; i < throws; i++)
            {
                int d1 = rand.Next(6) +1;
                int d2 = rand.Next(6) +1;
                both = (d1 + d2);
                counts[both-2]++;
            }

            
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1% of the total number of rolls.\nTotal number of rolls =" + throws);

            //return stars for each percentage of throws
            for (i = 0; i < counts.Length; i++)
            {
                starsCount = (int)Math.Round(((float)counts[i] / (float)throws) * 100);
                stars = new String('*', starsCount);
                
                Console.WriteLine((i + 2) + ":  "  + stars);
            }
            
        }
    }
}
