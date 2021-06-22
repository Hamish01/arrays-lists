using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_task
{
    class Program
    {
        static void Main(string[] args)
        {
            // using arrays 1
            Console.WriteLine("Enter 5 names:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();
            string input5 = Console.ReadLine();
            string[] array1 = {input1, input2, input3, input4, input5};
            Console.WriteLine("Hello "+ array1[1]);
            Console.WriteLine("Hello "+ array1[2]);
            Console.WriteLine("Hello "+ array1[3]);
            Console.WriteLine("Hello "+ array1[4]);
            Console.WriteLine("Hello "+ array1[0]);
            Console.WriteLine("press enter to continue:");
            Console.ReadLine();
            // using arrays 2
            int[] numArray = {34,5,67,1,99,34,44,78,34,0};
            int x = 0;
            int counter2 = 0;
            while (counter2 < 10)
            {
                
                x += numArray[counter2];
                counter2++;
            }
            Console.WriteLine("the total of the array is " + x);
            // lists 1/2
            Console.WriteLine("enter 5 numbers: ");
            List<int> NumList = new List<int>();
            int z = 0;
            while (z < 5){
                int numInput = Convert.ToInt32(Console.ReadLine());
                NumList.Add(numInput);
                z++;
            }
            Console.WriteLine("Enter a number to check for duplicates: ");
            int dupNum = Convert.ToInt32(Console.ReadLine()); 
            int Counter = 0;
            int Counter3 = 0;
            while(Counter3 < 5){
                if(NumList[Counter3] == dupNum){
                    Counter++;
                }
                Counter3++;
            }
            Console.WriteLine("There are " + Counter + " Duplicates of " + dupNum + " in the list");
            // Lists 3
            int Loop = 1;
            List<string> List = new List<string>();
            
            while(Loop != 0){
                Console.WriteLine("enter a word: ");
                string d = Console.ReadLine();
                if (d == "stop"){
                    int j = List.Count();
                    while(j > 0){
                        Console.WriteLine(List[j-1]);
                        j--;
                    }

                    Loop = 0;
                }

                List.Add(d);
            }


        }
    }
}
