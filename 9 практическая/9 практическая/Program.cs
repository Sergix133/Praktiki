using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass1 = new int[8, 8];
            int a = 1,h = -1;
            for (int i = 0; i < 8; i++){for (int j = 0; j < 8; j++) {h *= a * -1;mass1[i, j] = h;if (mass1[i,j] < 0){mass1[i, j] = 0;}Console.Write(mass1[i, j] + " ");}Console.WriteLine();h *= a * -1;}
            Console.ReadLine();
            int[,] mass2 = new int[10, 10];
            Random rnd = new Random();
            int sum = 0;
            for (int i =0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mass2[i, j] = rnd.Next(0, 10);
                    sum += mass2[i, j];
                    Console.Write(mass2[i,j] + " ");
                }
                Console.WriteLine("Сумма строки = "+sum);
                sum = 0;
            }
            Console.ReadLine();
        }
    }
}
