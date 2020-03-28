using System;
using System.Collections.Generic;
using System.Text;

namespace TriDiagonalMatrixAlgorithm
{
    class STDMS
    {
        static double[,] mainMatrix;
        static void Main(string[] args)
        {
            Console.WriteLine(@"The Tridiagnal Matrix is of the format below:
     A    *    T(n+1) =      T(n)
 _           _  _  _    _             _
|a b 0 ... 0 0| |T1|   |(j1 * Tx1) + k1|
|c d e ... 0 0| |T2|   |(j2 * Tx2)     |
|. . .  .  . .| |. |   |     .         |
|. . .  .  . .| |. | = |     .         |
|. . .  .  . .| |. |   |     .         |
|0 0 0 ... f g| |Tn|   |(jn * Txn) + kn|
|--         --| |--|   |-             -|
                                                                             ");

            Console.Write("\nEnter the size of the matrix or number of unknowns (n): ");
            int n = int.Parse(Console.ReadLine());
            double[] equivalentMatrix = new double[n];
            double[,] reducedMatrix = new double[n, 3];

            Console.Write("Enter the final time, T: ");
            double T = double.Parse(Console.ReadLine());

            Console.Write("Enter time step size, dT: ");
            double dT = double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            if (n == 3)
            {
                Console.WriteLine(@"
  A * T(n+1) =      T(n)
 _   _   __     _             _
|a b 0| |T1|   |(j1 * Tx1) + k1|
|c d e| |T2| = |(j2 * Tx2)     |
|0 f g| |T3|   |(j3 * Tx3) + k3|
|-   -| |--|   |-             -|");

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
            }
            else if (n == 4)
            {
                Console.WriteLine(@"
    A  * T(n+1) =     T(n)
 _     _   __     _             _
|a b 0 0| |T1|   |(j1 * Tx1) + k1|
|c d e 0| |T2|   |(j2 * Tx2)     |
|0 f g h| |T3| = |(j3 * Tx3)     |
|0 0 i j| |T4|   |(j4 * Tx4) + k4|
|--   --| |--|   |-             -|");

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
            }
            else if (n == 5)
            {
                Console.WriteLine(@"
    A  *  T(n+1) =     T(n)
 _            _   _  _     _               _
|a b 0 0 0| |T1|   |(j1 * Tx1) + k1|
|c d e 0 0| |T2|   |(j2 * Tx2)     |
|0 f g h 0| |T3| = |(j3 * Tx3)     |
|0 0 i j k| |T4|   |(j4 * Tx4)     |
|0 0 0 l m| |T5|   |(j5 * Tx5) + k5|
|--     --| |--|   |-             -|");

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
            }

            reducedMatrix[0, 0] = 0.0;
            reducedMatrix[n - 1, 2] = 0.0;

            mainMatrix = reducedMatrix;

            Console.WriteLine("\nEnter values of elements of matrix T(n) as shown in the matrix above: ");
            Console.WriteLine("Note that Txn represents the intial value at node n, jn is eht coefficient of Txn and kn is the added constant which is usually 0 except for the first and last elements of the matrix T(n)");

            double[] jn = new double[n];
            double[] kn = new double[n];
            for (int y = 0; y < n; y++)
            {
                Console.Write("j{0}: ", (y + 1));
                double p = double.Parse(Console.ReadLine());
                jn[y] = p;

                Console.Write("Tx{0}: ", (y + 1));
                double Tx = double.Parse(Console.ReadLine());

                double o;

                if (y==0 || y== (n-1))
                {
                    Console.Write("k{0}: ", (y + 1));
                    o = double.Parse(Console.ReadLine());
                    kn[y] = o;
                }
                else
                {
                    o = 0.0;
                    kn[y] = o;
                }

                equivalentMatrix[y] = ((p * Tx) + o);
            }          
                     
            Console.WriteLine("\n\nIt's recommended you hold your phone in landscape view first then press enter to view the answers");
            Console.ReadLine();
            Console.WriteLine("\nResults");
            Console.Write("Time(s)  ");
            for (int i = 0; i < n; i ++)
            {
                Console.Write("T{0}        ", (i+1));
            }
            for (double v = dT; v <= (T + dT); v+= dT)
            {
                double[,] reduced = new double[n, 3];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        reduced[i, j] = reducedMatrix[i, j];
                    }
                }
                double[] results = TDMASolver(reduced, equivalentMatrix, n);
                for (int r = 0; r < n; r++)

                {
                    equivalentMatrix[r] = ((jn[r] * results[r]) + kn[r]);                    
                }                

                Console.Write("\n{0,-6:#0.00}", v);
                for (int y = 0; y < n; y++)
                {
                    Console.Write("{0,-10:#0.0000}", results[y]);
                }                
            }

            
        }

        

        static double[] TDMASolver(double[,] Matrix, double[] equivalentMatrix, int n)
        {
            Matrix[0, 2] = Matrix[0, 2] / Matrix[0, 1];
            equivalentMatrix[0] = equivalentMatrix[0] / Matrix[0, 1];
            Matrix[0, 1] = 1.0;

            for (int y = 1; y < n; y++)
            {
                Matrix[y, 1] = Matrix[y, 1] - (Matrix[y, 0] * Matrix[y - 1, 2]);
                equivalentMatrix[y] = equivalentMatrix[y] - (Matrix[y, 0] * equivalentMatrix[y - 1]);
                equivalentMatrix[y] = equivalentMatrix[y] / Matrix[y, 1];
                Matrix[y, 2] = Matrix[y, 2] / Matrix[y, 1];
                Matrix[y, 0] = 0.0;
                Matrix[y, 1] = 1.0;
            }


            double[] results = new double[n];
            results[n - 1] = equivalentMatrix[n - 1];
            for (int y = n - 2; y >= 0; y--)
            {
                results[y] = equivalentMatrix[y] - (results[y + 1] * Matrix[y, 2]);
            }

            return results;
        }
    }
}
