using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            List<string> namesInput = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name:");
                string name = Console.ReadLine();
                namesInput.Add(name);
                Console.WriteLine("To enter another name, press any key. If you want to continue, press x");
                string answer = Console.ReadLine();
               if(answer.ToLower() == "x")
                {
                    break;
                }
                             
            }
            Console.WriteLine("Now enter text and see how many time the name is in the text");
            string text = Console.ReadLine();
            string[] splitInput = text.Split(' ');
            int counter = 0;
            foreach(string name in namesInput)
            {
                foreach(string substring in splitInput)
                {
                    if(name.ToLower()== substring.ToLower())
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The name {name} occurs {counter} times.");
                counter = 0;
            }



            Console.ReadLine();




        }
    }
}
