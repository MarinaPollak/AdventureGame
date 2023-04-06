using Pastel;
using System;
using static System.Console;

/* 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 

Used a guessing game from class demo
*/



namespace FashionWise3
{
    public class Colors
    {
        //var

        int guesses;
        string input;

        int target;

        string playerNameInput;
        string playerCountry;
        int playerAge;
        int playerXP;
        int Choice;
        int xp;
        public string charName;


        //initialize an array answers
        string[] ColorPallete = new string[8] { "red".Pastel("#f21326"), "blue".Pastel("#1353f2"), "green".Pastel("#15bd44"), "black".Pastel("#080808 ").PastelBg("#ffffff"), "white", "magenta".Pastel("#b50bd4"), "cyan".Pastel("#02dcf0"), "gray".Pastel("#7d8282").PastelBg("#b57689") };
        readonly Random rand = new Random();
        public Colors()
        {

        }

        public void ChooseColors()
        {
            bool running = true;

            while (running == true)
            {
                //pick a number
                target = rand.Next(ColorPallete.Length);

                WriteLine("\nGuess your colors");
                foreach (string color in ColorPallete)
                {
                    WriteLine(color);
                }

                input = ReadLine();
                input = input.ToLower();

                if (input == ColorPallete[target])
                {
                    guesses++;
                    WriteLine("You guessed correctly!");
                    WriteLine($"its took you to {this.guesses}");
                    break;

                }
                else
                {
                    guesses++;

                    WriteLine($"\nYou guessed {this.input} try again");
                    WriteLine("\npress enter to continue");
                    ReadLine();
                    Clear();
                }
            }
            Player myDesigner = new Player(playerNameInput, playerCountry, playerAge, playerXP, Choice);
            myDesigner.GainXP2(xp);
            myDesigner.DesignerMenu2(charName, xp);
            ReadLine();
            //WriteLine($"its took you to {this.guesses}");
            ReadLine();

            //WriteLine("\nit wasnt easy :), you can choose your model now and think what you going to draw for her\n");
            //Models models = new Models(Amira, Mila, Beverly, Shamaya);
            //models.ShowModels(Amira, Mila, Beverly, Shamaya);


        }
    }
}

