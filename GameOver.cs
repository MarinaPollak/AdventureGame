using Figgle;
using Pastel;
using System.Drawing;
using static System.Console;

/*
[Fashion Wise]
[Text Game]
[Marina Pollak]
[03/22/2022]
Mike Hadley showed me how to use Nuget packages Figgel and Pastel "Using NuGet for ASCII Text Banners & Fancy Colors" https://www.youtube.com/watch?v=HA0KKYprkzA
*/





namespace FashionWise3
{
    public class GameOver
    {

        public GameOver()
        {

        }
        public void EndGame()
        {
            string GameOver2 = FiggleFonts.Georgia16.Render("Game Over");
            WriteLine(GameOver2.Pastel("#bf4440"));
        }
        public void ColorGame()
        {
            string message1 = "What a day today?";
            //using System.Drawing.Color (which allows us to pass in r,g,b)
            Color foregraundColor = Color.FromArgb(235, 86, 52);
            Color backgraundColor = Color.FromArgb(143, 235, 52);
            string messageWithforegraund = message1.Pastel(foregraundColor);
            string messageWithforegroundAndBackgound = messageWithforegraund.PastelBg(backgraundColor);
            WriteLine($"{messageWithforegroundAndBackgound}");


            for (int g = 0; g <= 143; g += 10)
            {
                WriteLine(
                    "This is colorful..."
                        .Pastel(Color.FromArgb(g, 86, 53))
                        .Pastel(Color.FromArgb((g + 1) / 125))

                );
            }


        }

    }
}
