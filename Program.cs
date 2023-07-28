using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Selection Sort
            runApp();
            Console.ReadKey();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "Karuna";
            students[1] = "Mark";
            students[2] = "Advaith";
            students[3] = "Sangeeta";
            students[4] = "Nazia";
            students[5] = "Faisal";
            students[6] = "Tania";
            students[7] = "Guru";
            students[8] = "Chandni";
            students[9] = "Kamleshwar";

            int n = 10;
            string temp;
            int smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].CompareTo(students[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = students[smallest];
                students[smallest] = students[i];
                students[i] = temp;
            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }

    }
}
