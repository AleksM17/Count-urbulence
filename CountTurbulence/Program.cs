using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTurbulence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "7";
            int[] arr = new int[12];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(3, 10);
            }
            foreach (var item in arr)
            {
                Console.Write(item+"; ");
            }
            Console.WriteLine();
            Console.WriteLine(CountTurbul(arr));
        }
        static int CountTurbul(int[] arr)
        {
            int count = 0;
            int flag = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (flag == 0 && arr[i] != arr[i + 1])
                {
                    count++;
                    flag = (arr[i + 1] - arr[i] > 0) ? 1 : -1;
                }
                else if ((flag == -1 && (arr[i + 1] - arr[i] >= 0)) || (flag == 1 && (arr[i + 1] - arr[i] <= 0)))
                {
                    count++;
                    if (arr[i] == arr[i + 1]) flag = 0;
                    else flag = (arr[i + 1] - arr[i] > 0) ? 1 : -1;
                }
            }
            return count;
        }
    }
}
