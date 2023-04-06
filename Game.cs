using Pastel;
using System;
using static System.Console;

/* 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 

*/


namespace FashionWise3
{
    public class Game
    {

        //creating vars
        readonly string welcomeText = @"Here, you can become a fashion mogul and create your own trend-setting clothing empire. Design clothes, manage talent, promote your designs and build relationships with key players in the fashion world. With Fashion District, you'll have all the tools you need to live out your fashion dreams! Become the ultimate fashion mogul today - start building your empire now.";
        //int choice;
        //int choice;


        public string playerNameInput;
        public string playerCountry;
        public int playerAge;
        public int playerXP;
        public int Choice;
        string inputModelName;

        Model[] modelArray = new Model[5];

        static readonly string[] Content1 = {
    "\nWhat is your name?\n",
   "\nWhere are you from?",
   "\nWhat is your Age",
    "\nCongratulations! It wasnt easy, now choose your model!",
    "'OK'",
            "'YOUR OWN'",
    "\nEnter your colors below",
    "\nGreat now choose your model\n"

 };




        public void Intro()
        {

            ForegroundColor = ConsoleColor.DarkMagenta;
            Clear();
            TextAnimation.Blink(@"███████  █████  ███████ ██   ██ ██  ██████  ███    ██     ██████  ██ ███████ ████████ ██████  ██  ██████ ████████ 
██      ██   ██ ██      ██   ██ ██ ██    ██ ████   ██     ██   ██ ██ ██         ██    ██   ██ ██ ██         ██    
█████   ███████ ███████ ███████ ██ ██    ██ ██ ██  ██     ██   ██ ██ ███████    ██    ██████  ██ ██         ██    
██      ██   ██      ██ ██   ██ ██ ██    ██ ██  ██ ██     ██   ██ ██      ██    ██    ██   ██ ██ ██         ██    
██      ██   ██ ███████ ██   ██ ██  ██████  ██   ████     ██████  ██ ███████    ██    ██   ██ ██  ██████    ██    
                                             ");
            ForegroundColor = ConsoleColor.White;
            TextAnimation.AnimateWelcome(welcomeText);
            Clear();
            //Welcome to player

            Intrduction();
            Clear();



            Player myDesigner = new Player(playerNameInput, playerCountry, playerAge, playerXP, Choice);
            myDesigner.AboutDesigner();
            myDesigner.ConfirmInfo();


            //Materials materials = new Materials();
            //materials.chooseTextile();
            //ReadLine();


            GameOver gameOver1 = new GameOver();
            Clear();
            gameOver1.EndGame();
            gameOver1.ColorGame();
            ReadLine();

            WriteLine("\nPress enter to continue");


            Clear();
        }

        public void Intrduction()
        {

            WriteLine($"{Content1[0].Pastel("#1FBD9D")}");
            playerNameInput = ReadLine();
            //FiggleFonts.Bright.Render()


            WriteLine($"{Content1[1].Pastel("#1FBD9D")}");
            playerCountry = ReadLine();

            WriteLine($"{Content1[2].Pastel("#1FBD9D")}");
            playerAge = Convert.ToInt32(ReadLine());
        }



        public void PopulateModelArray()
        {
            //modelArray[5] = new Model();
            //add the instance of generic model


            //add achilles at index 1

            modelArray[0] = new Amira();

            //add odessus at index 2

            modelArray[1] = new Beverly();

            //add prometeus at index 3

            modelArray[2] = new Mila();


            modelArray[3] = new Shamaya();

            modelArray[4] = new Model();

        }


        //method that will print an endurance value for each hero
        //input parameter for index position

        public void PrintModelName(int _modelsArrayIndexposition)
        {
            WriteLine($"Model name: {modelArray[_modelsArrayIndexposition].GetModelName}");
            ReadLine();
            Clear();
        }

        public void PrintAge(int _modelsArrayIndexposition)
        {
            Write($"Age: {modelArray[_modelsArrayIndexposition].GetAge}");
            ReadLine();
            Clear();
        }

        public void DisplayModels()
        {
            foreach (Model model in modelArray)
            {
                model.ModelInfo();
                ReadLine();
            }
        }

        public void ModelsLook()
        {
            foreach (Model model in modelArray)
            {
                Clear();
                WriteLine($"Models Look: {model.GetModelName} {model.GetModelLook}");
                ReadLine();
            }

            ChooseModel();
        }

        //createmethod to prind each hero value to screen

        public void GetAllModelsValue()
        {

            foreach (Model model1 in modelArray)
            {
                Clear();
                WriteLine($"Models: {model1.GetModelName}");
                ReadLine();
            }


            Clear();

        }
        public void ChooseModel()
        {
            WriteLine("\nDid you make a choice? Enter the name below");
            inputModelName = ReadLine();
            Clear();
            if (inputModelName != null)
            {
                WriteLine("\nMake a sketch for her from this list, 'a' or 'b'");
                Sketches sketches = new Sketches();
                sketches.ChoiceSketch();
                WriteLine($"Great job your model{inputModelName} is looking great!");

            }
            else
            {
                Write("Please enter a model name below");
                inputModelName = ReadLine();

            }
        }






    }
}
