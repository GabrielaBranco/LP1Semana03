using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixA = new float[2, 2];
            matrixA[0, 0] = float.Parse(args[0]);
            matrixA[0, 1] = float.Parse(args[1]);
            matrixA[1, 0] = float.Parse(args[2]);
            matrixA[1, 1] = float.Parse(args[3]);

            var matrixB = new float[2, 1];
            matrixB[0, 0] = float.Parse(args[4]);
            matrixB[1, 0] = float.Parse(args[5]);

            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                float result = 0;
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    for (int x = 0; x < matrixB.GetLength(1); x++)
                    {
                        result += matrixA[i, j] * matrixB[j, x];
                    }
                }
                
                Console.WriteLine(result);
            }
        }
    }
}
