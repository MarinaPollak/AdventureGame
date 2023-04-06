using System;
using System.Threading;
using static System.Console;

/* 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 
Mike Hadley showed me how to use  Console Animation via Thread.Sleep System.Threading https://www.youtube.com/watch?v=A3UqpcQu4E0
*/

namespace FashionWise3
{
    class TextAnimation
    {
        public static void Blink(string text, int blinkCount = 5, int onTime = 500, int offTime = 200)
        {
            CursorVisible = false;
            for (int i = 0; i < blinkCount; i++)
            {
                WriteLine("\n\n");
                WriteLine(text);
                Thread.Sleep(onTime);
                Clear();
                Thread.Sleep(offTime);
            }
            WriteLine("\n\n");
            WriteLine(text);
            CursorVisible = true;
        }

        public static void AnimateWelcome(string welcomeText, int delay = 25)
        {
            for (int i = 0; i < welcomeText.Length; i++)
            {
                Write(welcomeText[i]);
                Thread.Sleep(delay);

                //If statement that skipd the animation if a key is pressed.Showing whole string
                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Write(welcomeText.Substring(i + 1));
                        break;
                    }

                }

            }
        }
    }
}
