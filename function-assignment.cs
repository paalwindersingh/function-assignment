using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FunctionAssignment
{
   class FunctionAssignment
   {
        static void Main(string[] args)
        {
            Console.Write("enter value of a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value of b ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter value of c ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(high(a, b, c));
            Console.WriteLine(high(a, b));
            Console.WriteLine(low(a, b, c));
            Console.WriteLine(low(a, b));
            Console.WriteLine(isOdd(a));
            Console.WriteLine(isEven(b));

            int [] marks = new int[] { 99, 98, 92, 97, 95, 8, 19};
            Console.WriteLine(contains(marks,8));
            Console.ReadKey();
        }

        static int high(int a, int b)
        {
            if (a > b)
            {
                return a;

            }
            else
            {
                return b;
            }
        }
        static int low(int a, int b)
        {
            if (a < b)
            {
                return a;

            }
            else
            {
                return b;
            }
        }

        static int high(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;

            }
            if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        static int low(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;

            }
            if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        static bool isOdd(int a)
        {
            if (a % 2 == 1)
            {
                return true;
            }
            else {
                return false;
            }
        }
        static bool isEven(int b)
        {
            if (b % 2 == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
        static bool contains(int[] array, int key)
        {
          for (int i = 1;i<=array.Length;i++){
              if(array[i] == key)
                  return true;
              else
                  return false;
                  
          }
            return false;
        }
   }
}
