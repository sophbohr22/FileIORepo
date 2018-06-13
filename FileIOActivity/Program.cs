﻿using System;
using System.Collections;
using System.IO;

namespace FileIOActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What File?");
            string path = Console.ReadLine();
            ArrayList numbers = new ArrayList();

            if (File.Exists(path)){
                using (StreamReader sr = File.OpenText(path)){
                    string s = "";
                    while ((s = sr.ReadLine()) != null){//while items still exist in the file
                        numbers.Add(Int32.Parse(s));//adds to array list and casts string to an int
                    }
                }

            }

            foreach (int i in numbers) {
                Console.WriteLine(i);//displaying all items in the arraylist
            }

            int sum = 0;

            //this for each loop adds all the numbers together
            foreach(int i in numbers) {
                sum = sum + i;
            }

            Console.WriteLine("The sum of all the numbers is: " + sum);

            Console.ReadKey();
            //file spot: 
        }
    }
}
