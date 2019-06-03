using System;

namespace ConsoleAppWorkShopMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //decimal x = 0.0M;
            string selection = "";
            bool keepAlive = true;

            int age = 0;
            float highet = 0.0f;
            string name = "";

            while (keepAlive)
            {
                Console.Clear();
                Console.WriteLine("---- Menu ----");
                selection = Console.ReadLine();

                switch (selection.ToUpper())
                {
                    case "NAME":
                        name = AskUserForName();
                        break;
                    case "AGE":
                        //age = AskUserForAge();
                        age = (int)AskUserForX("Age", 1, 120);
                        break;
                    case "HIGHET":
                        highet = AskUserForHighet();
                        break;
                    case "PERSON":
                        Console.WriteLine($"Person info\nName: {name}\nAge: {age}\nHighet: {highet}\n");
                        break;
                    case "EXIT":
                    case "Q":
                    case "QUIT":
                        Console.WriteLine("Will quit the program.");
                        keepAlive = false;
                        break;
                    default:
                        Console.WriteLine("Default was triggerd!");
                        break;
                }
                PressAnyKey();
            }

        }// End of Main

        /// <summary>
        /// Name length min 2, max 60
        /// </summary>
        /// <returns></returns>
        static string AskUserForName()
        {
            bool notAName = true;
            string name = "";
            do
            {
                Console.Write("Pleace enter the name of the person, minimum of two letters and maximum of 60 letters long\nName: ");
                name = Console.ReadLine();

                if (name.Length < 2 || name.Length > 60 || String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Read the rules for the name pleace.");
                }
                else
                {
                    notAName = false;
                }

            } while (notAName);

            return name;
        }

        static int AskUserForAge()
        {
            int result = -1;
            bool notANumber = true;

            do
            {
                Console.Write("Pleace enter persons age, minimum age is 1 and max is 120\nAge: ");
                int.TryParse(Console.ReadLine(), out result);

                if (result < 1 || result > 120)
                {
                    Console.WriteLine("Age must be within 1 to 120");
                }
                else
                {
                    notANumber = false;
                }

            } while (notANumber);

            return result;
        }

        static float AskUserForHighet()
        {
            float result = -1;
            bool notANumber = true;

            do
            {
                Console.Write("Pleace enter persons highet(meters), minimum is 0.3 and max is 3.0\nHighet: ");
                float.TryParse(Console.ReadLine(), out result);

                if (result < 0.3f || result > 3.0f)
                {
                    Console.WriteLine("Highet must be within 0.3 to 3.0");
                }
                else
                {
                    notANumber = false;
                }

            } while (notANumber);

            return result;
        }

        static double AskUserForX(string x, double min, double max)
        {
            bool notANumber = true;
            bool didPhars = false;
            double result = double.MaxValue;

            do
            {
                Console.WriteLine($"Pleace enter the persons {x}, min = {min} and max = {max}\n{x}: ");
                didPhars = double.TryParse(Console.ReadLine(), out result);

                if ( !didPhars )
                {
                    Console.WriteLine("Was not able to understand what number you typed, use digiets not text.");
                }
                else if (result < min || result > max)
                {
                    Console.WriteLine($"Maximum is {max} ans Minimum is {min}.");
                }
                else
                {
                    notANumber = false;
                }

            } while (notANumber);

            return result;
        }

        static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }


    }// End of Program
}// End of Namespace
