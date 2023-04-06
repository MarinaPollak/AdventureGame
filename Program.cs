using static System.Console;

/* 
 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 

*/


namespace FashionWise3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Title = "Fashion Wise";

            Game myGame1 = new Game();
            //invoke an Inro method

            myGame1.Intro();
            Clear();


            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
