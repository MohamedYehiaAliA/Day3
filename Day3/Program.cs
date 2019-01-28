using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{

    enum NumberType { 
    odd=1, even=2,Normal=3
    }
    struct Point
    {
       public int x;
       public int y;

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Point p1=new Point();
            p1.x=3;
            p1.y = 6;

             int[,] twoDim = new int[3,5];


             int[] arr = ReadNumbersFromUser(5);
            PrintArray(arr);

       

                Console.ReadKey();

            
        }

/// <summary>
/// Read numbers Form User
/// </summary>
/// <param name="arr">Integer number</param>
        static int[] ReadNumbersFromUser(int size) {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine("please enter number {0}", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        /// <summary>
        /// Print All values of Integer Array
        /// </summary>
        /// <param name="arr">Integer array</param>
        static void PrintArray(int[] Data) {
        
            for (int i = 0; i < Data.Length; i++) {
                Console.WriteLine(Data[i]);
            
            }
        }
    
    }
}
