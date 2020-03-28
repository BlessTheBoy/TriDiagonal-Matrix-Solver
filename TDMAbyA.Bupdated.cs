using System;

namespace TriDiagonalMatrixAlgorithm
{
    class TDMA
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(@"The Tridiagnal Matrix is of the format below:
         A       *     B    =   C
 _                _   _  _     _  _
|a  b  0  ...  0  0| | T1 |   | e1 |
|c  d  e  ...  0  0| | T2 |   | e2 |
|.  .  .   .   .  .| |  . |   | .  |
|.  .  .   .   .  .| |  . | = | .  |
|.  .  .   .   .  .| |  . |   | .  |
|0  0  0   .   f  g| | Tn |   | en |
|--              --| |-  -|   |-  -|
                                                                ");
            
            Console.Write("\nEnter the size of the matrix or number of unknowns (n): ");
            int n = int.Parse(Console.ReadLine());
            double[] equivalentMatrix = new double[n];
            double[,] reducedMatrix = new double[n, 3];

            if (n==3)
            {
                Console.WriteLine(@"
 _          _   _  _     _  _
| a    b    0| | T1 |   | e1 |
| c    d    e| | T2 | = | e2 |
| 0    f    g| | T3 |   | e3 |
|--        --| | - -|   |-  -|");

                Console.WriteLine("\nEnter all matrix value below as indicatred by the matrix above: ");
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a;

                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = b;

                Console.Write("c: ");
                double c = double.Parse(Console.ReadLine());
                reducedMatrix[1, 0] = c;

                Console.Write("d: ");
                double d = double.Parse(Console.ReadLine());
                reducedMatrix[1, 1] = d;

                Console.Write("e: ");
                double e = double.Parse(Console.ReadLine());
                reducedMatrix[1, 2] = e;

                Console.Write("f: ");
                double f = double.Parse(Console.ReadLine());
                reducedMatrix[2, 0] = f;

                Console.Write("g: ");
                double g = double.Parse(Console.ReadLine());
                reducedMatrix[2, 1] = g;

                for (int y = 0; y < n; y++)
                {
                    Console.Write("Enter e{0}:  ", (y + 1));
                    equivalentMatrix[y] = double.Parse(Console.ReadLine());
                }
            }
            else if (n==4)
            {
                Console.WriteLine(@"
 _               _   _  _     _  _
| a    b    0    0| | T1 |   | e1 |
| c    d    e    0| | T2 |   | e2 |
| 0    f    g    h| | T3 | = | e3 |
| 0    0    i    j| | T4 |   | e4 |
|--             --| | - -|   |-  -|");
					


				Console.WriteLine("\nEnter all matrix value below as indicatred by the matrix above: ");
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a;

                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = b;

                Console.Write("c: ");
                double c = double.Parse(Console.ReadLine());
                reducedMatrix[1, 0] = c;

                Console.Write("d: ");
                double d = double.Parse(Console.ReadLine());
                reducedMatrix[1, 1] = d;

                Console.Write("e: ");
                double e = double.Parse(Console.ReadLine());
                reducedMatrix[1, 2] = e;

                Console.Write("f: ");
                double f = double.Parse(Console.ReadLine());
                reducedMatrix[2, 0] = f;

                Console.Write("g: ");
                double g = double.Parse(Console.ReadLine());
                reducedMatrix[2, 1] = g;

                Console.Write("h: ");
                double h = double.Parse(Console.ReadLine());
                reducedMatrix[2, 2] = h;

                Console.Write("i: ");
                double i = double.Parse(Console.ReadLine());
                reducedMatrix[3, 0] = i;

                Console.Write("j: ");
                double j = double.Parse(Console.ReadLine());
                reducedMatrix[3, 1] = j;

                for (int y = 0; y < n; y++)
                {
                    Console.Write("Enter e{0}:  ", (y + 1));
                    equivalentMatrix[y] = double.Parse(Console.ReadLine());
                }
            }
            else if (n == 5)
            {
                Console.WriteLine(@"
 _                    _   _  _     _  _
| a    b    0    0    0| | T1 |   | e1 |
| c    d    e    0    0| | T2 |   | e2 |
| 0    f    g    h    0| | T3 | = | e3 |
| 0    0    i    j    k| | T4 |   | e4 |
| 0    0    0    l    m| | T5 |   | e5 |
|--                  --| | - -|   |-  -|");

				Console.WriteLine("\nEnter all matrix value below as indicatred by the matrix above: ");
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a;

                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = b;

                Console.Write("c: ");
                double c = double.Parse(Console.ReadLine());
                reducedMatrix[1, 0] = c;

                Console.Write("d: ");
                double d = double.Parse(Console.ReadLine());
                reducedMatrix[1, 1] = d;

                Console.Write("e: ");
                double e = double.Parse(Console.ReadLine());
                reducedMatrix[1, 2] = e;

                Console.Write("f: ");
                double f = double.Parse(Console.ReadLine());
                reducedMatrix[2, 0] = f;

                Console.Write("g: ");
                double g = double.Parse(Console.ReadLine());
                reducedMatrix[2, 1] = g;

                Console.Write("h: ");
                double h = double.Parse(Console.ReadLine());
                reducedMatrix[2, 2] = h;

                Console.Write("i: ");
                double i = double.Parse(Console.ReadLine());
                reducedMatrix[3, 0] = i;

                Console.Write("j: ");
                double j = double.Parse(Console.ReadLine());
                reducedMatrix[3, 1] = j;

                Console.Write("k: ");
                double k = double.Parse(Console.ReadLine());
                reducedMatrix[3, 2] = k;

                Console.Write("l: ");
                double l = double.Parse(Console.ReadLine());
                reducedMatrix[4, 0] = l;

                Console.Write("m: ");
                double m = double.Parse(Console.ReadLine());
                reducedMatrix[4, 1] = m;

                for (int y = 0; y < n; y++)
                {
                    Console.Write("Enter e{0}:  ", (y + 1));
                    equivalentMatrix[y] = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("\nEnter all matrix value below as indicatred by the matrix above: ");
                Console.Write("a: ");
                double a = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a;

                Console.Write("b: ");
                double b = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = b;

                Console.Write("c: ");
                double c = double.Parse(Console.ReadLine());
                for (int y = 1; y < n - 1; y++)
                {
                    reducedMatrix[y, 0] = c;
                }

                Console.Write("d: ");
                double d = double.Parse(Console.ReadLine());
                for (int y = 1; y < n - 1; y++)
                {
                    reducedMatrix[y, 1] = d;
                }

                Console.Write("e: ");
                double e = double.Parse(Console.ReadLine());
                for (int y = 1; y < n - 1; y++)
                {
                    reducedMatrix[y, 2] = e;
                }

                Console.Write("f: ");
                double f = double.Parse(Console.ReadLine());
                reducedMatrix[n - 1, 0] = f;

                Console.Write("g: ");
                double g = double.Parse(Console.ReadLine());
                reducedMatrix[n - 1, 1] = g;

                Console.WriteLine("\nAre there repetitive values between first and last elements of matrix C? ");
                Console.Write("Answer (yes/no):  ");
                string reply = Console.ReadLine().ToLower();

                if (reply == "yes" || reply == "y")
                {
                    Console.Write("e1: ");
                    double r = double.Parse(Console.ReadLine());
                    equivalentMatrix[0] = r;

                    Console.Write("e2: ");
                    double h = double.Parse(Console.ReadLine());
                    for (int y = 1; y < n - 1; y++)
                    {
                        equivalentMatrix[y] = h;
                    }

                    Console.Write("en: ");
                    double i = double.Parse(Console.ReadLine());
                    equivalentMatrix[n - 1] = i;
                }
                else if (reply == "no" || reply == "n")
                {
                    for (int y = 0; y < n; y++)
                    {
                        Console.Write("Enter e{0}:  ", (y + 1));
                        equivalentMatrix[y] = double.Parse(Console.ReadLine());
                    }
                }
            }            

            reducedMatrix[0, 0] = 0.0;
            reducedMatrix[n - 1, 2] = 0.0;
                        
            reducedMatrix[0, 2] = reducedMatrix[0, 2] / reducedMatrix[0, 1];
            equivalentMatrix[0] = equivalentMatrix[0] / reducedMatrix[0, 1];
            reducedMatrix[0, 1] = 1.0;

            for (int y = 1; y < n ; y++)
            {
                reducedMatrix[y, 1] = reducedMatrix[y, 1] - (reducedMatrix[y, 0] * reducedMatrix[y-1, 2]);
                equivalentMatrix[y] = equivalentMatrix[y] - (reducedMatrix[y, 0] * equivalentMatrix[y-1]);
                equivalentMatrix[y] = equivalentMatrix[y] / reducedMatrix[y, 1];
                reducedMatrix[y, 2] = reducedMatrix[y, 2] / reducedMatrix[y, 1];
                reducedMatrix[y, 0] = 0.0;
                reducedMatrix[y, 1] = 1.0;
            }
            

            double[] results = new double[n];
            results[n - 1] = equivalentMatrix[n - 1];
            for (int y = n-2; y >= 0; y--)
            {
                results[y] = equivalentMatrix[y] - (results[y + 1] * reducedMatrix[y, 2]);
            }

            Console.WriteLine("\n\nResults");
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine("T{0} = {1}", (y+1), results[y]);
            }
        } 
        
        static void Print1dMatrix(double[] print)
        {
            for (int u = 0; u < print.Length; u++)
            {
                Console.WriteLine("{0}", print[u]);
            }
        }

        static void Print2dMatrix(double[,] print)
        {
            for (int u = 0; u < print.GetLength(0); u++)
            {
                for (int v = 0; v < 3; v++)
                {
                    Console.Write("{0}  ", print[u,v]);
                }
                Console.WriteLine(" ");                    
            }
        }
    }
}
