using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts App";
            int choice = 0;
            Addition addTable = new Addition();
            Multiplication timeTables = new Multiplication();
            do
            {
                MainAppTitle();
                choice = MainMenu();
                if(choice == 1)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        addTable.AdditionTable();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                           
                        }
                        finally
                        {
                            if(startNum > 0 && endNum <= 10)
                            {
                                addTable.AdditionTable();
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Your addition table for {0} - {1}", startNum, endNum);
                                Console.WriteLine("");
                                addTable.AdditionChart(startNum, endNum);

                                Console.WriteLine("");
                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine("Would you like more addition facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if (moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                    }
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
                            }
                        }
                    } while (continueChoice == true);
                   
                }

                Console.ReadLine();
            if (choice == 2)
                {
                    bool continueChoice = true;
                    int startNum = 0;
                    int endNum = 0;
                    do
                    {
                        timeTables.MultiplyTable();
                        try
                        {
                            Console.WriteLine("Enter your starting number");
                            startNum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter your ending number");
                            endNum = Int32.Parse(Console.ReadLine());

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid number");
                            Console.ReadLine();
                            
                        }
                        finally
                        {
                            if (startNum > 0 && endNum <= 10)
                            {
                                Console.WriteLine("");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your multiplication table for {0} - {1}", startNum, endNum);
                                Console.ForegroundColor = ConsoleColor.White;
                                timeTables.MultiplyChart(startNum, endNum);

                                Console.WriteLine("");

                                try
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Would you like to continue with more multiplication facts [y/n]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    string moreFacts = Console.ReadLine();
                                    if(moreFacts == "y")
                                    {
                                        continueChoice = true;
                                    }
                                    else if (moreFacts == "n")
                                    {
                                        continueChoice = false;
                                        
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter y or n");
                                }

                            }
                        }
                    } while (continueChoice == true);
                }




            } while (choice != 3);
            

            

        }


        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select and option");
            Console.WriteLine("----------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: Addition Facts");
            Console.WriteLine("Option 2: Multiplication Facts");
            Console.WriteLine("Option 3: Leave Math Facts");
            //TODO - Fix exception handling
            choice = Int32.Parse(Console.ReadLine());
            return choice;
        }

        private static void MainAppTitle()
        {
            Console.Clear();
            string appTitle = @"___  ___      _   _      ______         _          ___              
|  \/  |     | | | |     |  ___|       | |        / _ \             
| .  . | __ _| |_| |__   | |_ __ _  ___| |_ ___  / /_\ \_ __  _ __  
| |\/| |/ _` | __| '_ \  |  _/ _` |/ __| __/ __| |  _  | '_ \| '_ \ 
| |  | | (_| | |_| | | | | || (_| | (__| |_\__ \ | | | | |_) | |_) |
\_|  |_/\__,_|\__|_| |_| \_| \__,_|\___|\__|___/ \_| |_/ .__/| .__/ 
                                                       | |   | |    
                                                       |_|   |_|    ";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(appTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
