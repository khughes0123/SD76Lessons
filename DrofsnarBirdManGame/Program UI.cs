using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrofsnarBirdManGame
{
    public class ProgramUI
    {
        Dictionary<string, int> birdScores = new Dictionary<string, int>() {
                { "Bird", 10 },
                { "CrestedIbis", 100 },
            {"GreatKiskudee", 300 },
            {"RedCrossbill", 500 },
            {"Red-neckedPhalarope", 700 },
            {"EveningGrosbeak", 1000 },
            {"GreaterPrairieChicken", 2000 },
            {"IcelandGull", 3000 },
            {"Orange-belliedParrot", 5000 }
            };
        int score = 5000;
        int lives = 3;

        // Game methods and stuff goes in here

        public void Run()
        {


            
            string gameString = File.ReadAllText(@"Drofsnar.txt");
            // return text.Split(',').ToList();
            string[] birds = gameString.Split(',');

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            bool hasEarnedExtraLife = false;
            int hunterScore = 200;
            int hunterCount = 0;

            Console.WriteLine($"|{"Bird",-30}|{"Score",-20}|{"Lives",-20}|");
            Console.WriteLine(new String('-', 74));

            foreach (string bird in birds)
            {
                // * Bird score points
                // * Bird takes a life
                // * Extra life?
                // * Bird scores exponential points (VulnerableBirdHunter)
                // * Game over?

                if (birdScores.ContainsKey(bird))
                {
                    score += birdScores[bird];
                } 
                else if (bird == "InvincibleBirdHunter")
                {
                    lives--;
                    hunterCount = 0;
                }
                else if (bird == "VulnerableBirdHunter")
                {
                    score += hunterScore * Convert.ToInt32(Math.Pow(2, hunterCount));
                    hunterCount++;
                }


                 if (score >= 10000 && !hasEarnedExtraLife)
                {
                    lives++;
                    hasEarnedExtraLife = true;
                }

                Thread.Sleep(50);
                Console.WriteLine($"|{bird, -30}|{score, -20}|{lives, -20}|");
                Console.WriteLine(new String('-', 64));

                 if (lives == 0)
                {
                    Console.WriteLine("You died:(");
                    break;
                }
            }
            Console.WriteLine(score);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // Pseudocode:
            // Get list of strings from file
            // Loop through strings
            //    Add appropriate score
            //    Check for extra life
            //    etc...
        }
    }


}
    

