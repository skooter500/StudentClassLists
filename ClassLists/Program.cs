using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Bryans version

namespace ClassLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("classlist.txt");
            System.IO.StreamWriter outFile = new System.IO.StreamWriter("out.txt");

            while ((line = file.ReadLine()) != null)
            {
                int i = line.IndexOf("@student.dit.ie");
                if (i != -1)
                {
                    int tab = line.LastIndexOf("\t", i);
                    string name = line.Substring(tab, (i  - tab) + 15);
                    name = name.Trim();
                    outFile.WriteLine(name);
                    Console.WriteLine(name);
                }            
            }
            Console.WriteLine("All done");
            Console.ReadLine();
        }
    }
}
