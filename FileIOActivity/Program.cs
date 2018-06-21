using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace FileIOActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What File?");
            string path = Console.ReadLine();
            List<int> numbers = new List<int>();
            int choice = 0;
            int end = -999;
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {//while items still exist in the file
                        numbers.Add(Int32.Parse(s));//adds to array list and casts string to an int
                    }
                }
                end = 57;
            }
            else
            {
                Console.WriteLine("Error. File not found.");
            }
            while (end != -999)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" (1) Display every odd number in the file ");
                Console.WriteLine(" (2) Display the sum of the numbers within the file ");
                Console.WriteLine(" (3) Display all numbers within the file");
                Console.WriteLine(" (4) Display every even number in the file");
                Console.WriteLine(" (5) Display the nubmers divisable by three");
                Console.WriteLine(" (6) Display every fifth number");
                Console.WriteLine(" (7) Quit application");
                choice = Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1: //every odd
                        Console.WriteLine("Every Odd:");
                        foreach (int i in numbers)
                        {
                            if (i % 2 == 1)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case 2://sum    
                        int sum = 0;
                        //this for each loop adds all the numbers together
                        foreach (int i in numbers)
                        {
                            sum = sum + i;
                        }
                        Console.WriteLine("The sum of all the numbers is: " + sum);
                        break;
                    case 3://display all
                        foreach (int i in numbers)
                        {
                            Console.WriteLine(i);//displaying all items in the arraylist
                        }
                        break;
                    case 4://every even
                        Console.WriteLine("Every Even:");
                        foreach (int i in numbers)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case 5://div by three
                        Console.WriteLine("Numbers divisible by 3: ");
                        foreach (int i in numbers)
                        {
                            if (i % 3 == 0)
                            {
                                Console.WriteLine(i);
                            }   
                        }
                        break;
                    case 6:// every fifth
                        Console.WriteLine("Every Fifth:");
                        int count = 0;
                        foreach (int i in numbers)
                        {
                            count++;
                            if (count % 5 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case 7:
                        end = -999;
                        break;
                    default:
                        Console.WriteLine("Not a valid command");
                        break;
                }
            }
            Console.WriteLine("PROGRAM TERMINATED");
            Console.ReadKey();
        }
    }
}
