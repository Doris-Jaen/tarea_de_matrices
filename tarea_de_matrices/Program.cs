using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_de_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
             {
            int N = 6;
            int D = 0;
            int C = 0;
            int K = 0;
            int[,] MATA = new int[100, 100];
            int[,] MATB = new int[100, 100];
            int[,] MATC = new int[N + 1, N + 1];

            Console.WriteLine("\n Matriz E");
            for (D = 1; D <= N; D++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 2, D + 2);
                    MATA[D, C] = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(C * 4, D + 8);
                    Console.Write(MATA[D, C]);
                }
            }
            Console.WriteLine("\n Matriz H");
            for (D = 1; D <= N; D++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 2, D + 14);
                    MATB[D, C] = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(C * 4, D + 20);
                    Console.Write(MATB[D, C]);
                }
            }

            for (D  = 1; D <= N; D++)
            {
                for (C = 1; C <= N; C++)
                {
                    for (K = 1; K <= N; K++)
                    {
                        MATC[D, C] = MATC[D, C] + (MATA[D, K] * MATB[K, C]);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("\n RESULTADO");
            for (D = 1; D <= N; D++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C * 4, D + 26);
                    Console.Write(MATC[D, C]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
        }
