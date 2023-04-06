using Pastel;
using System;
using System.Collections.Generic;
using static System.Console;

/* 
[Fashion Wise] 
[Text Game] 
[Marina Pollak]
[03/22/2022] 

List and iNstance from "programming is fun http://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_11_instances_lists/
*/


namespace FashionWise3
{
    public class Sketches
    {


        static int Scenarios = 3;
        static string CharacterName;
        static List<string> Samples = new List<string>();
        static string[] SketchOne = new string[] { "dress", "coctail-dress", "pants", "shorts", "coat" };
        static string[] SketchTwo = new string[] { "shoes", "flip-flops", "sneakers", "boots", "rubber boots" };
        static string[] SketchThree = new string[] { "hat", "scarf", "sun-glasses", "gloves" };

        public Sketches()
        {

        }
        public void ChoiceSketch()
        {
            for (int scenario = 1; scenario <= Scenarios; scenario++)
            {
                string input = "";

                switch (scenario)
                {
                    case 1:
                        //Part One

                        //same pattern for each of the sections. 1) write the first part of the section
                        WriteLine(SketchOne[0]);

                        //2)read in player's choice (a or b)
                        ForegroundColor = ConsoleColor.DarkMagenta;

                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();

                        //3) if a write the next part of the array, otherwise skip next and print 3rd
                        if (input == "a")
                        {
                            WriteLine($"{SketchOne[1]}");
                            Samples.Add("belt".Pastel("#1FBD9D"));
                            foreach (var item in Samples)
                            {
                                WriteLine(item);
                            }
                        }
                        else
                        {
                            WriteLine(SketchOne[2]);
                            Samples.Add("umbrella".Pastel("#1FBD9D"));
                        }

                        //4) write next part of the section
                        WriteLine(SketchOne[3]);

                        //5) again if a write next, otherwise skip ahead
                        if (input == "a")
                        {
                            WriteLine(SketchOne[4]);
                            Samples.Add("t-shirt".Pastel("#1FBD9D"));

                        }
                        else
                        {
                            WriteLine(SketchOne[4]);
                        }

                        //6) print last piece of the section
                        WriteLine(SketchOne[3]);

                        break;

                    case 2:
                        //Part Two

                        WriteLine(SketchTwo[0]);
                        ForegroundColor = ConsoleColor.DarkMagenta;
                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();
                        if (input == "a")
                        {
                            WriteLine(SketchTwo[1]);
                            Samples.Add("fure".Pastel("#1FBD9D"));
                        }
                        else
                        {
                            WriteLine(SketchTwo[2]);
                            Samples.Add("chisel");
                        }
                        WriteLine(SketchTwo[3]);
                        if (input == "a")
                        {
                            WriteLine(SketchTwo[4]);
                            Samples.Add("leather coat".Pastel("#1FBD9D"));
                        }
                        else
                        {
                            WriteLine(SketchTwo[3]);
                            Samples.Add("jeanse".Pastel("#1FBD9D"));
                        }
                        WriteLine(SketchTwo[4]);

                        break;

                    case 3:
                        //Part Three

                        WriteLine(SketchThree[0]);
                        ForegroundColor = ConsoleColor.DarkMagenta;
                        Write("Enter your choice: ");
                        input = ReadLine();
                        input = input.ToLower();
                        ResetColor();
                        if (input == "a")
                        {
                            WriteLine(SketchThree[1]);
                            Samples.Add("sweater".Pastel("#1FBD9D"));
                        }
                        else
                        {
                            WriteLine(SketchThree[2]);
                        }
                        WriteLine(SketchThree[3]);
                        if (input == "b")
                        {
                            WriteLine(SketchThree[3]);
                            Samples.Add("short-skirt".Pastel("#1FBD9D"));
                        }
                        else
                        {
                            WriteLine(SketchThree[3]);
                            Samples.Add("bag".Pastel("#1FBD9D"));
                        }
                        WriteLine(SketchThree[3]);
                        break;

                    default:
                        //default if section number does not match one of the above
                        break;
                }

                //let player advance when ready, then clear the screen
                WriteLine("Press enter to continue...");
                ReadKey();
                Clear();
            }
        }

    }
}
