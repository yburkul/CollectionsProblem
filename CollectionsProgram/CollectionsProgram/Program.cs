﻿using System;
namespace CollectionsProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Collections Program");
            int input;
            do
            {
                Console.WriteLine("\n1: Add Stack");
                Console.WriteLine("0: Exit the Program\n");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Collections.AddStack();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invaild Input:----Please Enter a Correct Input");
                        break;
                }

            }
            while (input != 0);
           
        }
    }
}

