using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int baseNum = 123;
            Console.WriteLine(Doubling(baseNum));

            string al = "Greenfox";
            Greet(al);

            string typo = "Chinchill";
            Console.WriteLine(AppenAFunc(typo));

            Console.WriteLine("Please enter integers: ");
            //int sum = Sum(Console.ReadLine());
            //Console.WriteLine("The sum is : " + sum);

            Console.WriteLine("Please enter a number: ");
            //int fac = Factorio(int.Parse(Console.ReadLine()));
            //Console.WriteLine("The factorial of the number is: "+fac);

            //Third
            int[] q = { 4, 5, 6, 7 };
            Console.WriteLine(q[2]);

            //Compare Length
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            Console.WriteLine("If p2 has more elements than p1: {0}", p2.Length > p1.Length);

            //Sum elements
            int[] r = { 54, 23, 66, 12 };
            Console.WriteLine("The sum of the second and the third element is: {0}", r[1] + r[2]);

            //Change element
            int[] s = { 1, 2, 3, 8, 5, 6 };
            for (int i = 0; i < s.Length;i++)
            {
                if(s[i]==8)
                {
                    s[i] = 4;
                }
            }
            Console.WriteLine(s[3]);

            //Increment element *
            int[] t = { 1, 2, 3, 4, 5 };
            s[2]++;
            Console.WriteLine(s[2]);

            //Print element
            int[] numbers = { 4, 5, 6, 7 };
            foreach(int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //Matrix
            int[,] matrix = new int[4,4];
            for (int i = 0; i < 4;i++)
            {
                for (int j = 0; j < 4;j++)
                {
                    if(i==j)
                    {
                        matrix[i,j] = 1;
                    }
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Double items
            int[] numList = { 3, 4, 5, 6, 7 };
            for (int i = 0; i < numList.Length;i++)
            {
                numList[i] *= 2;
            }

            //Colors
            string[,] colors ={
                {"lime", "forest green", "olive", "pale green", "spring green"},
                {"orange red", "red", "tomato","",""},
                {"orchid", "violet", "pink", "hot pink",""}
            };

            //Append a
            string[] animals = { "koal", "pand", "zebr" };
            for (int i = 0; i < animals.Length;i++)
            {
                animals[i] += "a";
            }

            //Swap elements
            string[] abc = { "first", "second", "third" };
            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            //Sum all elements
            int[] ai = { 3, 4, 5, 6, 7 };
            int sum1 = 0;
            foreach(int num in ai)
            {
                sum1 += num;
            }
            Console.WriteLine("The sum of the elements in ai is: " + sum1);

            //Reverse list
            int[] aj = { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);
            foreach(int num in aj)
            {
                Console.Write(num + " ");
            }

            Console.ReadLine();

        }

        public static int Doubling(int number)
        {
            return number * 2;
        }       
        
        public static void Greet(string str)
        {
            Console.WriteLine("Greetings dear, " + str);
        }

        public static string AppenAFunc(string str)
        {
            return str + "a";
        }

        public static int Sum(string str)
        {
            string[] s = new string[100];
            s = str.Split(' ');
            int sum = 0;
            for (int i = 0; i < s.Length;i++)
            {
                sum += Convert.ToInt32(s[i]);
            }
            return sum;
        }

        public static long Factorio(int number)
        {
            long fac = 1;
            for (int i = 1; i <= number;i++)
            {
                fac *= i;
            }
            return fac;
        }
    }
}
