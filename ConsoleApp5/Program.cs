using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            int[] array1 = new int[n];

            for(int i=0;i<n;i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            //for(int i=0;i<n;i++)
            //{
            //    Console.WriteLine(array1[i]);

            //}

            Console.WriteLine("Enter the value of sum of the 3 elements");
            int sum = int.Parse(Console.ReadLine());

            int[] array2 = new int[3];

            for (int i=0;i<n;i++)
            {
                if (array1[i] < 0)
                {
                    Console.WriteLine("-1");
                    
                }

                else
                {
                    for (int m = 0; m < n - 2; m++)
                    {
                        for (int j = m + 1; j < n - 1; j++)
                        {
                            for (int k = j + 1; k < n; k++)
                            {
                                if ((array1[m] + array1[j] + array1[k]) == sum)
                                {
                                    array2[0] = array1[m];
                                    array2[1] = array1[j];
                                    array2[2] = array1[k];
                                }
                            }
                        }
                    }
                    

                }


            }

            for (int p = 0; p < 3; p++)
            {

                Console.WriteLine(array2[p]);
            }



            Console.ReadKey();
        }
    }
}
