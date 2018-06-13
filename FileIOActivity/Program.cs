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

            if (File.Exists(path)){
                using (StreamReader sr = File.OpenText(path)){
                    string s = "";
                    while ((s = sr.ReadLine()) != null){//while items still exist in the file
                        numbers.Add(Int32.Parse(s));//adds to array list and casts string to an int
                    }
                }

            }
            foreach (int i in numbers){
                Console.WriteLine(i);//displaying all items in the arraylist
            }
            
            Console.WriteLine("Every Fifth:");
           int count = 0;
           foreach (int i in numbers){
               count++;
                if(count%5 == 0){
                    Console.WriteLine(i);
                }
           }
            Console.ReadKey();
            //file spot: 
        }
    }
}
