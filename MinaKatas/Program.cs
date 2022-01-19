using System;
using System.Linq.Expressions;

namespace MinaKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*To do...
             * Skapa:
             * 1. Metod som gör om int till char. (kolla ascii listan)
             * 2. Metod som kallas på 100 000 gånger.
             * 3. Metod som kallar på en annan metod som kallar på en tredje metod som kallar
             *    på en fjärde. Hur blir kodflödet när du steppar igenom?
             * 4. Metod som kallar på en annan metod som kallar tillbaka på första metoden ad infinitum.
             * 5. Metod som kallar på sig själv för att bygga låttexten "99 bottles of beer"
             * 6. Gör samma sak fast med while sats istället
             *
             * 7. Print out a cube
             */

            //1.
            Console.WriteLine(IntToChar(80));

            //2.
            for (int i = 0; i < 100000; i++)
            {
                IntToChar(0);
            }

            //3.
            //FirstMethod();

            //4. (OBS! Skapar STACKOVERFLOWException)
            //FirstInfinity();

            //5. 
            //BottlesOfBeerOnTheWall();

            //6. 
            //WhileBottlesOfBeerOnTheWall(8);

            //7. 
            while (true)
            {
                Console.Clear();
                Console.Write("Write a whole number: ");
                int num = int.Parse(Console.ReadLine());
                CreateCube(num);
                Console.Write("Press enter to draw another cube.\nPress any key and enter to exit");
                if (!(string.IsNullOrEmpty(Console.ReadLine())))
                    break;
            }
        }

        /// <summary>
        /// Den här metoden gör om en siffra(int) till ascii kodens bokstavsmotsats(char)
        /// </summary>
        /// <param name="number">Nummret du vill konvertera till bokstav</param>
        static char IntToChar(int number)
        {
            return (char) number;
        }

        /// <summary>
        /// Metod som kallar på en annan metod
        /// </summary>
        static void FirstMethod()
        {
            SecondMethod();
        }

        /// <summary>
        /// Metod som kallar på en tredje metod
        /// </summary>
        static void SecondMethod()
        {
            ThirdMethod();
        }

        /// <summary>
        /// Metod som visar att alla metoder blev kallade på
        /// </summary>
        static void ThirdMethod()
        {
            Console.WriteLine("You have reached the final method!");
        }

        /// <summary>
        /// Börjar och fortsätter den oändliga loopen mellan första och andra metoden.
        /// </summary>
        static void FirstInfinity()
        {
            SecondInfinity();
        }

        /// <summary>
        /// Fortsätter den oändliga loopen mellan metoderna
        /// </summary>
        static void SecondInfinity()
        {
            FirstInfinity();
        }

        /// <summary>
        /// Den här metoden kommer att skriva ut sången "99 bottle of beer on the wall" men har
        /// egenskapen att man kan skriva in ett värde i bottles och på så sätt ändra hur många flaskor
        /// som man börjar med i låten.
        /// </summary>
        /// <param name="bottles">Antalet flaskor som räknar ned varje gång metoden kallas</param>
        /// <param name="bottleText">Själva låttexten</param>
        static void BottlesOfBeerOnTheWall(int bottles = 99, string bottleText = "")
        {
            if (bottles >= 3)
            {
                bottleText += bottles + " bottles of beer on the wall, " + bottles + " bottles of beer.\n" +
                              "Take one down and pass it around, " + (bottles - 1) + " bottles of beer on the wall.\n";
                BottlesOfBeerOnTheWall(--bottles, bottleText);
            }
            else if (bottles == 2)
            {
                bottleText += "2 bottles of beer on the wall, 2 bottles of beer.\n" +
                              "Take one down and pass it around, 1 bottle of beer on the wall.\n";
                BottlesOfBeerOnTheWall(--bottles, bottleText);
            }
            else if (bottles == 1)
            {
                bottleText += "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                              "Take one down and pass it around, no more bottles of beer on the wall.\n";
                BottlesOfBeerOnTheWall(--bottles, bottleText);
            }
            else
            {
                string originalNmbrOfBottles = "";
                foreach (char x in bottleText)
                {
                    if (!(Char.IsDigit(x)))
                        break;
                    originalNmbrOfBottles += x;
                }

                if (String.IsNullOrEmpty(originalNmbrOfBottles))
                {
                    originalNmbrOfBottles = "0 bottles of beer on the wall.";
                }
                else if (Int32.Parse(originalNmbrOfBottles) == 1)
                {
                    originalNmbrOfBottles = "1 bottle of beer on the wall.";
                }
                else
                {
                    originalNmbrOfBottles += " bottles of beer on the wall.";
                }

                Console.WriteLine(bottleText + "No more bottles of beer on the wall, no more bottles of beer.\n" +
                                  "Go to the store and buy some more, "+ originalNmbrOfBottles + " bottles of beer on the wall.");
            }
            
        }

        /// <summary>
        /// Gör samma sak som metoden "BottlesOfBeerOnTheWall" fast med en while-loop istället.
        /// </summary>
        static void WhileBottlesOfBeerOnTheWall(int bottles = 99)
        {
            string bottleText = "";
            while (bottles >= 0)
            {
                if (bottles >= 3)
                {
                    bottleText += bottles + " bottles of beer on the wall, " + bottles + " bottles of beer.\n" +
                                  "Take one down and pass it around, " + (bottles - 1) + " bottles of beer on the wall.\n";

                }
                else if (bottles == 2)
                {
                    bottleText += "2 bottles of beer on the wall, 2 bottles of beer.\n" +
                                  "Take one down and pass it around, 1 bottle of beer on the wall.\n";
                }
                else if (bottles == 1)
                {
                    bottleText += "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                                  "Take one down and pass it around, no more bottles of beer on the wall.\n";
                }
                else
                {
                    string originalNmbrOfBottles = "";
                    foreach (char x in bottleText)
                    {
                        if (!(Char.IsDigit(x)))
                            break;
                        originalNmbrOfBottles += x;
                    }

                    if (String.IsNullOrEmpty(originalNmbrOfBottles))
                    {
                        originalNmbrOfBottles = "0 bottles of beer on the wall.";
                    }
                    else if (Int32.Parse(originalNmbrOfBottles) == 1)
                    {
                        originalNmbrOfBottles = "1 bottle of beer on the wall.";
                    }
                    else
                    {
                        originalNmbrOfBottles += " bottles of beer on the wall.";
                    }

                    Console.WriteLine(bottleText + "No more bottles of beer on the wall, no more bottles of beer.\n" +
                                      "Go to the store and buy some more, " + originalNmbrOfBottles);
                }

                bottles--;
            }
        }

        /// <summary>
        /// Metod som skriver ut en kub av stjärnor
        /// </summary>
        /// <param name="x">Antalet rader och columner i kuben</param>
        static void CreateCube(int x)
        {
            for (int i = 0; i < x; i++)
            {
                string stars = "";
                for (int j = 0; j < x; j++)
                {
                    stars += "*";
                }
                Console.WriteLine(stars);
            }
        }
    }
}