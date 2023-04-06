using Pastel;
using System;
using static System.Console;


/* 
 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 

Used character demo from class demos

*/


namespace FashionWise3
{
    public class Player
    {
        public string charName;
        public string placeOfrigin;
        public int Age;
        public int xp;
        public string Answer;
        public string Menu;

        //static bool Run = true;
        static int Choice;
        static int Choice1;
        private string input;
        private string input1;
        //static bool Goal = false;
        private readonly int choice;

        string border;
        string border1;

        static readonly string[] Content = {
    "Press enter to continue...",
    "\nLets start a game! 'OK'",
    "4) Continue",
    "\nCongratulations! It wasnt easy, now choose your model!",
    "'OK'",
            "'YOUR OWN'",
    "\nEnter your colors below",
    "\nGreat now choose your model\n"
 };




        public void AboutDesigner()
        {
            WriteLine($"\n{this.charName.Pastel("#1FBD9D")}\n");
            WriteLine($"You are designer from {this.placeOfrigin.Pastel("#1FBD9D")}");
            WriteLine($"{this.Age} old");
            WriteLine($"Your charachter experinace is {this.xp}");


        }
        public void Format2(string Menu)
        {
            border1 = " ";

            Write("\n\n");
            Border1(Menu.Length - 22);
            WriteLine(Menu);
            Border1(Menu.Length - 22);
            Write("\n\n");
            ResetColor();
        }
        public void Border1(int spaces)
        {

            for (int i = 0; i < spaces; i++)
            {
                Write($"{border1.Pastel("#bf4440")}");

            }
            Write("\n");
        }


        public void Format1(string Menu)
        {
            border = "=";
            Write("\n\n");
            Border(Menu.Length - 22);
            WriteLine(Menu);
            Border(Menu.Length - 22);
            Write("\n\n");
            ResetColor();
        }

        public void Format(string Menu)
        {
            border = "=";
            Write("\n\n");
            Border(Menu.Length);
            WriteLine(Menu);
            Border(Menu.Length);
            Write("\n\n");
            ResetColor();
        }

        //Create a border that is the same length as the fortune string
        public void Border(int spaces)
        {

            for (int i = 0; i < spaces; i++)
            {
                Write($"{border.Pastel("#bf4440")}");

            }
            Write("\n");
        }

        public void DesignerMenu2(string charName, int xp)
        {
            Menu = $" Designer:{this.charName} 1) Start 2) Score:{this.xp} 3) Exit {Content[2].Pastel("#1FBD9D")}";
            Format1(Menu);
            Choice1 = Convert.ToInt32(ReadLine());
            if (Choice1 == 3)
            {
                GameOver gameOver = new GameOver();
                gameOver.EndGame();
            }
            else
            {
                switch (Choice1)
                {
                    case 1:
                        WriteLine(Content[1]);
                        ReadLine();
                        Materials materials = new Materials();
                        materials.ChooseTextile();
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    case 2:
                        WriteLine($"Your current score is {this.xp} points");
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    case 3:
                        WriteLine("C content...");
                        GameOver gameOver = new GameOver();
                        gameOver.EndGame();
                        WriteLine(Content[0]);
                        ReadLine();
                        break;
                    case 4:
                        //content here....
                        WriteLine(Content[4]);
                        input1 = ReadLine();

                        if (input1 == "ok")
                        {
                            Game game = new Game();
                            game.PopulateModelArray();

                            game.PrintModelName(0);
                            game.PrintAge(0);

                            game.PrintModelName(1);
                            game.PrintAge(1);

                            game.PrintModelName(2);
                            game.PrintAge(2);

                            game.PrintModelName(3);
                            game.PrintAge(3);

                            game.DisplayModels();


                            game.GetAllModelsValue();

                            game.ModelsLook();
                        }
                        else
                        {
                            WriteLine("Are you tired? want to get back tomorrow? You will start from beginning!");
                            ReadLine();
                            GameOver gameOver1 = new GameOver();
                            gameOver1.EndGame();

                        }
                        break;

                    default:
                        WriteLine("Please enter a number 1-4.");
                        WriteLine(Content[0]);
                        ReadLine();
                        break;
                }
            }
        }

        public void DesignerMenu1(string _charName, int _xp)
        {
            Menu = $" Designer: {this.charName} 1) Start 2) Score:{this.xp} 3) Exit {Content[2].Pastel("#1FBD9D")}";
            Format1(Menu);
            Choice1 = Convert.ToInt32(ReadLine());
            if (Choice1 == 3)
            {
                GameOver gameOver = new GameOver();
                gameOver.EndGame();
            }
            else
            {
                switch (Choice1)
                {
                    case 1:
                        WriteLine(Content[1]);
                        ReadLine();
                        Materials materials = new Materials();
                        materials.ChooseTextile();
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    case 2:
                        WriteLine($"Your current score is {this.xp} points");
                        //content here....
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    case 3:
                        WriteLine("C content...");
                        GameOver gameOver = new GameOver();
                        gameOver.EndGame();
                        WriteLine(Content[0]);
                        ReadLine();
                        break;
                    case 4:
                        //content here....
                        WriteLine($"\nNow guess your colors and gain 100 points! {Content[4].Pastel("#1FBD9D")}");
                        WriteLine($"\nOr choose your own for Zero point! {Content[5].Pastel("#1FBD9D")}");

                        input = ReadLine();
                        input.ToLower();

                        if (input == "ok")
                        {
                            Colors colors = new Colors();
                            colors.ChooseColors();
                        }
                        else if (input != "ok")
                        {
                            WriteLine($"{Content[6].Pastel("#1FBD9D")}");
                            ReadLine();

                            WriteLine($"{Content[7].Pastel("#1FBD9D")}");


                            Game game = new Game();
                            game.PopulateModelArray();

                            game.PrintModelName(0);
                            game.PrintAge(0);

                            game.PrintModelName(1);
                            game.PrintAge(1);

                            game.PrintModelName(2);
                            game.PrintAge(2);

                            game.PrintModelName(3);
                            game.PrintAge(3);

                            game.DisplayModels();


                            game.GetAllModelsValue();

                            game.ModelsLook();

                        }
                        else
                        {
                            WriteLine("Want to try again?");
                            ReadLine();

                        }

                        break;

                    default:
                        WriteLine("Please enter a number 1-4.");
                        WriteLine(Content[0]);
                        ReadLine();
                        break;
                }
            }
        }

        public void DesignerMenu(string _charName, int _xp)
        {
            Menu = ($" Designer:{this.charName} 1) Start 2) Score:{this.xp} 3) Exit ");
            Format(Menu);


            Choice = Convert.ToInt32(ReadLine());
            if (Choice == 3)
            {
                GameOver gameOver = new GameOver();
                gameOver.EndGame();
            }
            else
            {
                switch (Choice)
                {
                    case 1:
                        WriteLine(Content[1]);
                        ReadLine();
                        Materials materials = new Materials();
                        materials.ChooseTextile();
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    case 2:
                        WriteLine($"Your current score is {this.xp} points");
                        //content here....
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    case 3:
                        WriteLine("C content...");
                        GameOver gameOver = new GameOver();
                        gameOver.EndGame();
                        WriteLine(Content[0]);
                        ReadLine();
                        break;

                    default:
                        WriteLine("Please enter a number 1-3.");
                        WriteLine(Content[0]);
                        ReadLine();
                        break;
                }
            }
        }

        public void ConfirmInfo()
        {
            WriteLine("Is this is correct?");
            Answer = ReadLine();
            Clear();
            if (Answer == "yes")
            {

                DesignerMenu(charName, xp);
                ReadLine();

            }
            else if (Answer == "no")
            {
                Clear();
                WriteLine("Lets try again!");
                Game game = new Game();
                game.Intrduction();
                ConfirmInfo();
            }
            else
            {
                WriteLine("Please enter yes or no");
            }

        }

        //build a constructor with 3 input characters
        public Player(string _charName, string _placeOfrigin, int _Age, int _xp, int _choice)
        {
            this.charName = _charName;
            this.placeOfrigin = _placeOfrigin;
            this.Age = _Age;
            this.xp = _xp;
            this.choice = _choice;
        }




        //game experience pints
        //use input parameters
        public void GainXP1(int xp)
        {
            this.xp += 50;
        }
        public void GainXP2(int xp)
        {
            this.xp += 150;
        }
    }
}
