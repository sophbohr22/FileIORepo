using System;
using System.Collections;
using System.IO;
using System.Collections;

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
                    while ((s = sr.ReadLine()) != null){
                        numbers.Add(Int32.Parse(s));
                    }
                }

            }
            foreach (int i in numbers){
                Console.WriteLine(i);
            }

            Console.ReadKey();
            //file spot: 
        }
    }
}
