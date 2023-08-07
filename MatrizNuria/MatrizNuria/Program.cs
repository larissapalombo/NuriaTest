using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Olá, esse programa inverte as diagonais de uma matriz quadrada.");
        Console.Write("Digite o tamanho da matriz quadrada (somente número)");
        int size = int.Parse(Console.ReadLine());

        int[,] matriz = new int[size, size];

        Console.WriteLine("Digite cada elemento da matriz (somente números):");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write($"Matriz[{i}][{j}] = ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Matriz original:");
        PrintMatriz(matriz);

        InverseMatriz(matriz);

        Console.WriteLine("Matriz com diagonais invertidas:");
        PrintMatriz(matriz);
    }

    static void InverseMatriz(int[,] matriz)
    {
        int size = matriz.GetLength(0);

        for (int i = 0; i < size; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, size - 1 - i];
            matriz[i, size - 1 - i] = temp;
        }
    }

    static void PrintMatriz(int[,] matriz)
    {
        int size = matriz.GetLength(0);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}