using System;
using static System.Console;


namespace FashionWise3
{
    public class Materials
    {
        string[] materials = new string[16] { "silk", "chiffon", "denim", "linen", "fleece", "damask", "polyester", "wool", "cotton", "poplin", "curduroy", "velevet", "chintz", "terry", "batiste", "gabardine" };
        int materialCount = 1;
        string materialInput;
        int materialInputInt;
        private Random RandomGenerator;
        int randomMaterials;
        string Input;

        string playerNameInput;
        string playerCountry;
        int playerAge;
        int playerXP;
        int Choice;
        int xp;
        string charName;



        public Materials()
        {
            RandomGenerator = new Random();
            materialInputInt = 1;

        }

        public void ChooseTextile()
        {
            for (int i = 0; i < materials.Length; i++)
            {
                WriteLine($"\n{materialCount++}.{materials[i]}\n");
            }
            WriteLine("Do u know what materials you want to choose? 'YES' or 'NO'");
            materialInput = ReadLine();

            Clear();

            if (materialInput == "no")
            {
                WriteLine("\nHere is your given materials!\n");
                randomMaterials = RandomGenerator.Next(1, 16);
                randomMatChoice();
            }
            else if (materialInput == "yes")
            {
                WriteLine("Enter material number");
                materialInputInt = Convert.ToInt32(ReadLine());
                Clear();

                if (materialInputInt == 1)
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[0]} and additional {materials[4]} for your design challenege \n");
                    AcceptingMat();

                }
                else if (materialInputInt == 2)
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[1]} and additional {materials[5]} for your design challenege \n");
                    AcceptingMat();
                }
                else if ((materialInputInt == 3))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[2]} and additional {materials[6]} for your design challenege \n");
                    AcceptingMat();
                }
                else if ((materialInputInt == 4))
                {
                    Write($"\nYou have entered {materialInputInt} here is your materiale {materials[3]} and additional {materials[7]} for your design challenege \n");
                    AcceptingMat();
                }
                else if ((materialInputInt == 5))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[4]} and additional {materials[8]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 6))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[5]} and additional {materials[9]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 7))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[6]} and additional {materials[10]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 8))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[7]} and additional {materials[11]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 9))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[8]} and additional {materials[12]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 10))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[9]} and additional {materials[13]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 11))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[10]} and additional {materials[14]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 12))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[11]} and additional {materials[15]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 13))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[12]} and additional {materials[16]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 14))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[13]} and additional {materials[10]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 15))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[14]} and additional {materials[9]} for your design challenege \n");
                    AcceptingMat();

                }
                else if ((materialInputInt == 16))
                {
                    Write($"\nYou have entered {materialInputInt} here is your material {materials[15]} and additional {materials[11]} for your design\n");
                    AcceptingMat();

                }
            }

        }

        public void randomMatChoice()
        {
            if (randomMaterials == 1)
            {
                WriteLine($" you have to make a sketch from {materials[0]} and {materials[1]}");
                AcceptingMat();

            }
            else if (randomMaterials == 2)
            {
                WriteLine($" you have to make a sketch from {materials[1]} and {materials[2]}");
                AcceptingMat();

            }
            else if (randomMaterials == 3)
            {
                WriteLine($" you have to make a sketch from {materials[2]} and {materials[3]}");
                AcceptingMat();
            }
            else if (randomMaterials == 4)
            {
                WriteLine($" you have to make a sketch from {materials[3]} and {materials[4]}");
                AcceptingMat();
            }
            else if (randomMaterials == 5)
            {
                WriteLine($" you have to make a sketch from {materials[4]} and {materials[5]}");
                AcceptingMat();
            }
            else if (randomMaterials == 6)
            {
                WriteLine($" you have to make a sketch from {materials[5]} and {materials[6]}");
                AcceptingMat();
            }
            else if (randomMaterials == 7)
            {
                WriteLine($" you have to make a sketch from {materials[6]} and {materials[7]}");
                AcceptingMat();
            }
            else if (randomMaterials == 8)
            {
                WriteLine($" you have to make a sketch from {materials[7]} and {materials[8]}");
                AcceptingMat();
            }
            else if (randomMaterials == 9)
            {
                WriteLine($" you have to make a sketch from {materials[8]} and {materials[9]}");
                AcceptingMat();
            }
            else if (randomMaterials == 10)
            {
                WriteLine($" you have to make a sketch from {materials[9]} and {materials[10]}");
                AcceptingMat();
            }
            else if (randomMaterials == 11)
            {
                WriteLine($" you have to make a sketch from {materials[10]} and {materials[11]}");
                AcceptingMat();
            }
            else if (randomMaterials == 12)
            {
                WriteLine($" you have to make a sketch from {materials[11]} and {materials[12]}");
                AcceptingMat();
            }
            else if (randomMaterials == 13)
            {
                WriteLine($" you have to make a sketch from {materials[12]} and {materials[13]}");
                AcceptingMat();
            }
            else if (randomMaterials == 14)
            {
                WriteLine($" you have to make a sketch from {materials[13]} and {materials[14]}");
                AcceptingMat();
            }
            else
            {
                WriteLine($" you have to make a sketch from {materials[14]} and {materials[15]}");
                AcceptingMat();
            }
        }

        public void AcceptingMat()
        {

            WriteLine("\nTo accept type 'YES'");
            Write("To deny type 'NO'");
            Input = ReadLine();
            if (Input == "yes")

            {
                Player myDesigner = new Player(playerNameInput, playerCountry, playerAge, playerXP, Choice);
                myDesigner.GainXP1(xp);
                myDesigner.DesignerMenu1(charName, xp);

            }
            else
            {
                WriteLine("Lets try again");
                ChooseTextile();
            }
        }

    }


}
