using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, esse é um programa que conta quantas vezes uma matriz B é encontrada na matriz A.");
        Console.WriteLine("O tamanho da matriz B deve ser menor que a matriz A.");
        Console.WriteLine("Digite o número de linhas da matriz A:");
        int rowsA = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas da matriz A:");
        int colsA = int.Parse(Console.ReadLine());

        int[,] matrizA = InsertMatriz("A", rowsA, colsA);

        Console.WriteLine("Digite o número de linhas da submatriz B:");
        int rowsB = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número de colunas da submatriz B:");
        int colsB = int.Parse(Console.ReadLine());

        if (rowsB >= rowsA || colsB >= colsA)
        {
            Console.WriteLine("Tamanho da matriz B deve ser menor que o tamanho da matriz A.");
            return;
        }

        int[,] matrizB = InsertMatriz("B", rowsB, colsB);

        int count = CountB(matrizA, matrizB);

        Console.WriteLine($"A matriz B aparece {count} vezes na matriz A.");
    }

    static int[,] InsertMatriz(string name, int rows, int cols)
    {
        int[,] matriz = new int[rows, cols];

        Console.WriteLine($"Digite os elementos da matriz {name}:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"[{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matriz;
    }

    static int CountB(int[,] matrizA, int[,] matrizB)
    {
        int count = 0;
        int rowsA = matrizA.GetLength(0);
        int colsA = matrizA.GetLength(1);
        int rowsB = matrizB.GetLength(0);
        int colsB = matrizB.GetLength(1);

        for (int i = 0; i <= rowsA - rowsB; i++)
        {
            for (int j = 0; j <= colsA - colsB; j++)
            {
                if (SumMatriz(matrizA, matrizB, i, j))
                {
                    count++;
                }
            }
        }

        return count;
    }

    static bool SumMatriz(int[,] matrizA, int[,] matrizB, int startRow, int startCol)
    {
        int rowsB = matrizB.GetLength(0);
        int colsB = matrizB.GetLength(1);

        for (int i = 0; i < rowsB; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                if (matrizA[startRow + i, startCol + j] != matrizB[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}