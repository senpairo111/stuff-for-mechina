using System;


namespace project4mechina
{
    class Program
    {




        static void Main(string[] args)
        {
            int choice = 0;
            while (choice < 8)
            {
                choice = 0;
                Console.WriteLine("\n\ntype the number to choose what to run \n1. pyramid \n2. average\n3. hack\n4. epic math \n5. numCompare\n6. geometry \n7. abxc\n8,9,10... close\n\n");
                while(choice < 1)
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("please type a valid choice");
                    }
                }
                switch (choice)
                {
                    case 1:
                        functions.Pyramid();
                    break;
                    case 2:
                        functions.Average();
                    break;
                    case 3:
                        functions.Hack();
                    break;
                    case 4:
                        functions.EpicMath();
                    break;
                    case 5:
                        functions.numCompare();
                    break;
                    case 6:
                        functions.geometry();
                    break;
                    case 7:
                        functions.abxc();
                    break;
                    default:
                        Console.WriteLine("\n\n\n\n will now close the program, thanks 4 trying it out! \n\n\n\n");
                    break;


                }
            }
            /*Console.WriteLine("text 4 the pyramid:");
            string text = Console.ReadLine();
            Console.WriteLine("seperator 4 the pyramid:");
            string seperator = Console.ReadLine();
            Console.WriteLine("number of rows in the pyramid:");
            int number = int.Parse(Console.ReadLine());


            string[] stuff = new string[number];
            int count = 0;
            while (count < number)
            {
                stuff.SetValue(text, count);
                Console.WriteLine(string.Join(seperator, stuff));


                count += 1;
            }
            */


            //double number1 = number * 10;
            //double number2 = (number + number1) / 2;
            //Console.WriteLine("number = {0} number1 = {1} average = {2}", number, number1, number2);


            /*Console.WriteLine("who do you want to hack?");
            string target = Console.ReadLine();
            Console.WriteLine("hacking {0}...", target);
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("succesfully hacked {0}", target);
            */


            /*
            Console.WriteLine("lets do geometry");
            Console.WriteLine("square's edge:");
            float edge = float.Parse(Console.ReadLine());
            Console.WriteLine("scope = {0}   surface area = {1}   diagonal = {2}", edge * 4, edge * edge, MathF.Sqrt(edge * edge + edge * edge));



            Console.WriteLine("wanna do math? \n enter YES      anything else NO");
            string confirmation = Console.ReadLine();
            while (confirmation == "")
            {
                Console.WriteLine(" A * X + B = C \n type in A value:");
                float A = float.Parse(Console.ReadLine());
                Console.WriteLine(" type in B value:");
                float B = float.Parse(Console.ReadLine());
                Console.WriteLine(" type in C value:");
                float C = float.Parse(Console.ReadLine());
                Console.WriteLine("X = {0}", (C - B) / A);
                Console.WriteLine("wanna do more math? \n enter YES      anything else NO");
                confirmation = Console.ReadLine();
            }


            Console.WriteLine("gonna check which number is higher between two numbers and if they are even or odd, gimme numbers");
            Console.WriteLine("first number:");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("second number:");
            float secondNum = float.Parse(Console.ReadLine());


            Console.WriteLine("{0} is the higher number \n the first number is even = {1} \n the second number is even = {2}", MathF.Max(firstNum, secondNum), firstNum % 2 == 0, secondNum % 2 == 0);





            
                Console.WriteLine("wanna do math? \n enter YES      anything else NO");
            confirmation = Console.ReadLine();
            while (confirmation == "")
            {
                Console.WriteLine("first number:");
                float A = float.Parse(Console.ReadLine());
                Console.WriteLine("operator:");
                string B = Console.ReadLine();
                while (B != "*" && B != "/" && B != "-" && B != "+")
                {
                    Console.WriteLine("please type in a real operator:");
                    B = Console.ReadLine();
                }
                Console.WriteLine("second number:");
                float C = float.Parse(Console.ReadLine());
                switch (B)
                {
                    case "*":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A * C);
                        break;
                    case "/":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A / C);
                        break;
                    case "-":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A - C);
                        break;
                    case "+":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A + C);
                        break;

                }
                 * 
                 * if(B == "*")
                {
                    Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A * C);
                }
                else if (B == "/")
                {
                    Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A / C);
                }
                else if (B == "-")
                {
                    Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A - C);
                }
                else if (B == "+")
                {
                    Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A + C);
                }
                Console.WriteLine("wanna do more math? \n enter YES      anything else NO");
                confirmation = Console.ReadLine();
                */
                

            }

        }



    class functions
    {
        public static void Pyramid()
        {
            Console.WriteLine("text 4 the pyramid:");
            string text = Console.ReadLine();
            Console.WriteLine("seperator 4 the pyramid:");
            string seperator = Console.ReadLine();
            Console.WriteLine("number of rows in the pyramid:");
            int number = int.Parse(Console.ReadLine());


            string[] stuff = new string[number];
            int count = 0;
            while (count < number)
            {
                stuff.SetValue(text, count);
                Console.WriteLine(string.Join(seperator, stuff));


                count += 1;
            }
        }







        public static void Average()
        {
            Console.WriteLine("first number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("second number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("average = {0}", (number + number1) / 2);
        }







        public static void Hack()
        {
            Console.WriteLine("who do you want to hack?");
            string target = Console.ReadLine();
            Console.WriteLine("hacking {0}...", target);
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("succesfully hacked {0}", target);
        }







        public static void EpicMath()
        {
            
                Console.WriteLine("first number:");
                float A = float.Parse(Console.ReadLine());
                Console.WriteLine("operator:");
                string B = Console.ReadLine();
                while (B != "*" && B != "/" && B != "-" && B != "+")
                {
                    Console.WriteLine("please type in a real operator:");
                    B = Console.ReadLine();
                }
                Console.WriteLine("second number:");
                float C = float.Parse(Console.ReadLine());
                switch (B)
                {
                    case "*":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A * C);
                        break;
                    case "/":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A / C);
                        break;
                    case "-":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A - C);
                        break;
                    case "+":
                        Console.WriteLine("{0} {1} {2} = {3}", A, B, C, A + C);
                        break;

                
                }

        }


        public static void numCompare()
        {
            Console.WriteLine("gonna check which number is higher between two numbers and if they are even or odd, gimme numbers");
            Console.WriteLine("first number:");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("second number:");
            float secondNum = float.Parse(Console.ReadLine());


            Console.WriteLine("{0} is the higher number \n the first number is even = {1} \n the second number is even = {2}", MathF.Max(firstNum, secondNum), firstNum % 2 == 0, secondNum % 2 == 0);
        }


        public static void geometry()
        {
            Console.WriteLine("square's edge:");
            float edge = float.Parse(Console.ReadLine());
            Console.WriteLine("scope = {0}   surface area = {1}   diagonal = {2}", edge * 4, edge * edge, MathF.Sqrt(edge * edge + edge * edge));



            
            
        }




        public static void abxc()
        {
            
            
                Console.WriteLine(" A * X + B = C \n type in A value:");
                float A = float.Parse(Console.ReadLine());
                Console.WriteLine(" type in B value:");
                float B = float.Parse(Console.ReadLine());
                Console.WriteLine(" type in C value:");
                float C = float.Parse(Console.ReadLine());
                Console.WriteLine("X = {0}", (C - B) / A);
                
            
        }
    }
    }
