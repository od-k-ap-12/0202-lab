using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0202lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            int uniquenumbers = 1;
            int oddnumbers = 0;
            int evennumbers = 0;
            int[] arr = new int[] {1,2,3,4,9,10,2,2,5,6,6,7,8,9,10};
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            int currentnumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evennumbers++;
                }
                else
                {
                    oddnumbers++;
                }
                if (currentnumber != arr[i])
                {
                    currentnumber = arr[i];
                    uniquenumbers++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Unique:{uniquenumbers}");
            Console.WriteLine($"Odd:{oddnumbers}");
            Console.WriteLine($"Even:{evennumbers}");

            #endregion

            #region 2
            int result = 0;
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < number)
                {
                    result++;
                }
            }
            Console.WriteLine($"Result:{result}");

            #endregion

            #region 3
            result = 0;
            int[] arr2 = new int[] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5};
            Console.WriteLine("Enter 3 digits :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == a1)
                {
                    if (arr2[i + 1] == a2)
                    {
                        if (arr2[i + 2] == a3)
                        {
                            result++;
                        }
                    }
                }

            }
            Console.WriteLine($"Result:{result}");

            #endregion


        }
    }
}
