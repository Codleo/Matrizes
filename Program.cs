
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        Console.WriteLine("Enter the size of the matrix Line,Column:");
        string[] line = Console.ReadLine().Split(" ");
        int l = int.Parse(line[0]);
        int c = int.Parse(line[1]);
        int[,] mat = new int[l, c];
        Console.WriteLine("Enter the values of the matrix:");

        for (int i = 0; i < l; i++)
        {
            string[] values = Console.ReadLine().Split(" ");
            for (int j = 0; j < c; j++)
            {
                mat[i, j] = int.Parse(values[j]);
                if (mat[i, j] < 0)
                {
                    count++;
                }
            }
        }
        Console.WriteLine("Main Diagonal:");
        for (int i = 0; i < l; i++)
        {
            Console.WriteLine(mat[i, i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Negative numbers: " + count);

        Console.WriteLine('\n' + "Enter the main number of your matrix");
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < l; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (mat[i, j] == x)
                {
                    Console.WriteLine("Position " + i + ", " + j + ":");
                    if (j > 0)
                        Console.WriteLine("Left: " + mat[i, j - 1]);

                    if (i > 0)
                        Console.WriteLine("Up: " + mat[i - 1, j]);

                    if (j < c - 1)
                        Console.WriteLine("Right: " + mat[i, j + 1]);

                    if (i < l - 1)
                        Console.WriteLine("Down: " + mat[i + 1, j]);

                }
            }
        }
    }
}