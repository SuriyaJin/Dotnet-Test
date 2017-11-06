using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of asset details :");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] _seat = new string[n];
            int[] tot = new int[n];
            string[] avail = new string[n];
            int sum = 0;
            int temp;
            string temp1;




            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the asset serial number :");
                string _serialNo = Console.ReadLine();

                Console.WriteLine("Enter the asset allocation of all months in a year :");
                _seat[i] = Console.ReadLine();

                string a = _seat[i];



                for (int j = 0; j < 12; j++)
                {
                    sum = sum + Convert.ToInt32(new string(a[j], 1));
                }

                tot[i] = sum;
                avail[i] = _serialNo;
                sum = 0;

                Console.WriteLine("tot " + i + " " + tot[i] + " " +avail[i]);
            }
          /*  for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tot[i] + " " + avail[i]);
            }
            */
          /*  for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {

                    if (tot[i] < tot[j])
                    {

                        temp = tot[i]; temp1 = avail[i];

                        tot[i] = tot[j]; avail[i] = avail[j];

                        tot[j] = temp; avail[j] = temp1;

                    }
                    else if (tot[i] == tot[j]) 
                    {
                       
                    }



                   for (int k = 0; k < n; k++)
                    {
                        Console.Write(tot[k] + "," + avail[k]+" -- " );
                    }
                    Console.WriteLine("\n");
                }

            }*/
            for (int i = 0; i < n; i++)
            {

                for (int j = i + 1; j < n; j++)
                {
                    if (tot[i] < tot[j])
                    {

                        temp = tot[i]; temp1 = avail[i];

                        tot[i] = tot[j]; avail[i] = avail[j];

                        tot[j] = temp; avail[j] = temp1;

                    }
                }
            }


            Console.WriteLine("Asset utilization order:");

            for (int i = 0; i < n ; i++)
            {

                Console.WriteLine(avail[i]+" "+tot[i]);

            }
         



           




            Console.ReadLine();
        }
    }
}
