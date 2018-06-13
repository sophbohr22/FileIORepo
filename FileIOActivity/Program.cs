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
            //ArrayList numbers = new ArrayList(); 
            List<int> numbers = new List<int>();
            if (File.Exists(path)){
                using (StreamReader sr = File.OpenText(path)){
                    string s = "";
                    while ((s = sr.ReadLine()) != null){//while items still exist in the file
                        numbers.Add(Int32.Parse(s));//adds to array list and casts string to an int
                    }
                }

            }else{
                Console.WriteLine("Error. File not found.");
            }
            foreach (int i in numbers){
                Console.WriteLine(i);//displaying all items in the arraylist
            }
            //everyOdd
            Console.WriteLine("Every Odd:");
            foreach (int i in numbers){
                if(i%2 == 1){
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            

        }
    }
}
