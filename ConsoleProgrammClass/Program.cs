using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgrammClass
{

    using System;

    namespace Program1
    {
        public class Matrix
        {
            private double[,] DoubleArray = null;
            private int n = 0, m = 0;

            public int ElementCount
            {
                get
                {
                    return n * m;
                }
            }

            public double ScalarMultiply
            {
                set
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            DoubleArray[i, j] = DoubleArray[i, j] * value;
                        }
                    }
                }
            }

            public Matrix(int rowsCount, int columnsCount)
            {
                n = rowsCount;
                m = columnsCount;
                DoubleArray = new double[n, m];
            }

            public void EnterElements()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("Enter element {0},{1} :  ", i, j);
                        DoubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }

            public void PrintMatrix()
            {
                Console.Out.Write('\n');
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(DoubleArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }


        class MainConsole
        {
            static void Main()
            {
                Matrix M = new Matrix(2, 2);
                M.EnterElements();
                M.PrintMatrix();

                Console.Out.Write("\nОбщее кол-во элементов в массиве: " + M.ElementCount);
                M.ScalarMultiply = 10;      
                M.PrintMatrix();            
                Console.Read();
            }
        }
    }
}
