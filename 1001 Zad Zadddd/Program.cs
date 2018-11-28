using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001_Zad_Zadddd
{
    class Program
    {/*Дадена е редица от K елемента, съдържаща естествени числа от интервала [1..101]. Числото K е от същия интервал.
      Да се състави програма, която извежда най-дългата ненамаляваща подредица.
Пример: K=12; 5,6,1,3,2,4,5,6,7,2,8,9 Изход: 2, 4, 5, 6, 7*/
        static void Main(string[] args)
        {int lenght=new int();
            Console.WriteLine("How many numbers do you intend on writing?:");
            lenght = Convert.ToInt32(Console.ReadLine());
            string[] snums = new string[lenght];
            int[] numbers = new int[lenght];
            Console.WriteLine("Type in the numbers you want,with a space between them:");
            snums = Console.ReadLine().Split();
            for(int i=0;i<lenght;i++)
            {
                numbers[i] = Convert.ToInt32(snums[i]);
            };
            int[] growingnums = new int[lenght];
            int sequence = 0;
            int maxsequence=0;
            int startindex = 0;
            int endofsequence = 0;
            for(int i=0;i<lenght-1;i++){
                if (numbers[i] < numbers[i + 1])
                {
                    sequence++;
                  

                }
                else
                {
                    endofsequence = i+1;
                    if (sequence > maxsequence)
                    {
                        Array.Clear(growingnums,0, growingnums.Length);
                        maxsequence = sequence;
                        sequence = 0;
                        for (; startindex < endofsequence;startindex++ )
                        {
                            growingnums[startindex] = numbers[startindex];
                        }

                    }
                    
                }
            } Console.WriteLine("This is the longest increasing sequence:");
            foreach (int num in growingnums)
            {
                if(num!=0)
                Console.Write(num+" ");
            }
            

            
        }
    }
}
