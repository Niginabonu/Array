using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int m = int.Parse(num[1]);
            int p = int.Parse(num[2]);



            string[,] str = new string[n, m];
            int[,] arr = new int[n, m];


            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();

                for (int j = 0; j < m; j++)
                {
                    str[i, j] = s[j];
                    arr[i, j] = int.Parse(s[j]);


                }


            }

            Console.ReadLine();

            string[,] str1 = new string[m, p];
            int[,] arr1 = new int[m, p];

            for (int j = 0; j < m; j++)
            {
                string[] s1 = Console.ReadLine().Split();

                for (int k = 0; k < p; k++)
                {

                    str1[j, k] = s1[k];
                    arr1[j, k] = int.Parse(s1[k]);

                }



            }

            int[,] result = new int[n, p];

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < p; k++)
                {
                    result[i, k] = 0;

                    for (int j = 0; j < m; j++)
                    {


                        result[i, k] += arr[i, j] * arr1[j, k];

                    }

                }



            }


            for (int i = 0; i < n; i++)
            {


                for (int k = 0; k < p; k++)
                {
                    Console.Write(result[i, k] + " ");

                }

                Console.WriteLine();

            }




            //Console.ReadKey();


        }
    }
}
