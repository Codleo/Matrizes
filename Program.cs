
using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        Console.WriteLine("Enter the size of the matrix Line,Column:");
        int l = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
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
    }
}