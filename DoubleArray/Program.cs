using System;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
        Task15();
        Task16();
        Task17();
        Task18();
        Task19();
    }

    static void Task1()
    {
        Console.WriteLine("Task 1:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -20, 25);
        PrintMatrix(matrix);
    }

    static void Task2()
    {
        Console.WriteLine("Task 2:");
        int[,] matrix = GenerateRandomMatrix(3, 4, 1, 5);
        int[] sums = SumOfRows(matrix);
        for (int i = 0; i < sums.Length; i++)
        {
            Console.WriteLine($"Сумма строки {i} : {sums[i]}");
        }
    }

    static void Task3()
    {
        Console.WriteLine("Task 3:");
        int[,] matrix = GenerateRandomMatrix(3, 4, -30, 45);
        int smallestElement = FindSmallestElement(matrix);
        Console.WriteLine($"Наименьший элемент: {smallestElement}");
    }

    static void Task4()
    {
        Console.WriteLine("Task 4:");
        int[,] matrix = GenerateRandomMatrix(3, 4, -5, 5);
        (int smallest, int rowIndex) = FindSmallestElementAndRowIndex(matrix);
        Console.WriteLine($"Наименьший элемент: {smallest} в строке {rowIndex}");
    }

    static void Task5()
    {
        Console.WriteLine("Task 5:");
        int[,] matrix = new int[4, 4];
        matrix[0, 0] = 1; matrix[0, 1] = 0; matrix[0, 2] = 0; matrix[0, 3] = 0;
        matrix[1, 0] = 0; matrix[1, 1] = 1; matrix[1, 2] = 0; matrix[1, 3] = 0;
        matrix[2, 0] = 0; matrix[2, 1] = 0; matrix[2, 2] = 1; matrix[2, 3] = 0;
        matrix[3, 0] = 0; matrix[3, 1] = 0; matrix[3, 2] = 0; matrix[3, 3] = 1;
        PrintMatrix(matrix);
    }

    static void Task6()
    {
        Console.WriteLine("Task 6:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int columnIndex = FindColumnWithLargestNegativeCount(matrix);
        Console.WriteLine($"Столбец с наибольшим отрицательным числом: {columnIndex}");
    }

    static void Task7()
    {
        Console.WriteLine("Task 7:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        SortColumnsAscending(matrix);
        PrintMatrix(matrix);
    }

    static void Task8()
    {
        Console.WriteLine("Task 8:");
        int[,] matrix = new int[3, 4];
        matrix[0, 0] = 1; matrix[0, 1] = 1; matrix[0, 2] = 1; matrix[0, 3] = 1;
        matrix[1, 0] = 2; matrix[1, 1] = 2; matrix[1, 2] = 2; matrix[1, 3] = 2;
        matrix[2, 0] = 3; matrix[2, 1] = 3; matrix[2, 2] = 3; matrix[2, 3] = 3;
        PrintMatrix(matrix);
    }

    static void Task9()
    {
        Console.WriteLine("Task 9:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int largestOdd = FindLargestOddNumber(matrix);
        Console.WriteLine($"Самое большое нечетное число: {largestOdd}");
    }

    static void Task10()
    {
        Console.WriteLine("Task 10:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -98, 54);
        int[] evenCounts = CountEvenElementsInColumns(matrix);
        for (int i = 0; i < evenCounts.Length; i++)
        {
            Console.WriteLine($"Даже посчитать в столбце {i} : {evenCounts[i]}");
        }
    }

    static void Task11()
    {
        Console.WriteLine("Task 11:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int evenNegativeCount = CountEvenNegativeElements(matrix);
        Console.WriteLine($"Даже отрицательный счет: {evenNegativeCount}");
    }

    static void Task12()
    {
        Console.WriteLine("Task 12:");
        int[,] matrix = new int[4, 4];
        matrix[0, 0] = 1; matrix[0, 1] = 2; matrix[0, 2] = 3; matrix[0, 3] = 4;
        matrix[1, 0] = 1; matrix[1, 1] = 2; matrix[1, 2] = 3; matrix[1, 3] = 4;
        matrix[2, 0] = 1; matrix[2, 1] = 2; matrix[2, 2] = 3; matrix[2, 3] = 4;
        matrix[3, 0] = 1; matrix[3, 1] = 2; matrix[3, 2] = 3; matrix[3, 3] = 4;
        PrintMatrix(matrix);
    }

    static void Task13()
    {
        Console.WriteLine("Task 13:");
        int[,] matrix = new int[4, 4];
        matrix[0, 0] = 0; matrix[0, 1] = 0; matrix[0, 2] = 0; matrix[0, 3] = 1;
        matrix[1, 0] = 0; matrix[1, 1] = 0; matrix[1, 2] = 1; matrix[1, 3] = 0;
        matrix[2, 0] = 0; matrix[2, 1] = 1; matrix[2, 2] = 0; matrix[2, 3] = 0;
        matrix[3, 0] = 1; matrix[3, 1] = 0; matrix[3, 2] = 0; matrix[3, 3] = 0;
        PrintMatrix(matrix);
    }

    static void Task14()
    {
        Console.WriteLine("Task 14:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int largestElement = FindLargestElement(matrix);
        Console.WriteLine($"Самый большой элемент: {largestElement}");
    }

    static void Task15()
    {
        Console.WriteLine("Task 15:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int[] products = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int product = 1;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                product *= matrix[i, j];
            }
            products[i] = product;
        }
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Продукт ряда {i} : {products[i]}");
        }
    }

    static void Task16()
    {
        Console.WriteLine("Task 16:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, matrix.GetLength(1) - i - 1];
        }
        Console.WriteLine($"Сумма вторичной диагонали: {sum}");
    }

    static void Task17()
    {
        Console.WriteLine("Task 17:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int columnIndex = FindColumnWithSmallestNegativeCount(matrix);
        Console.WriteLine($"Столбец с наименьшим отрицательным количеством: {columnIndex}");
    }

    static void Task18()
    {
        Console.WriteLine("Task 18:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int smallestEven = FindSmallestEvenNumber(matrix);
        Console.WriteLine($"Наименьшее четное число: {smallestEven}");
    }

    static void Task19()
    {
        Console.WriteLine("Task 19:");
        int[,] matrix = GenerateRandomMatrix(5, 5, -10, 10);
        int largestMultipleOf3 = FindLargestMultipleOf3(matrix);
        Console.WriteLine($"Наибольшее кратное 3: {largestMultipleOf3}");
    }

    static int[,] GenerateRandomMatrix(int N, int M, int min, int max)
    {
        Random random = new Random();
        int[,] matrix = new int[N, M];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matrix[i, j] = random.Next(min, max + 1);
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[] SumOfRows(int[,] matrix)
    {
        int[] sums = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            sums[i] = sum;
        }
        return sums;
    }

    static int FindSmallestElement(int[,] matrix)
    {
        int min = int.MaxValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }
        return min;
    }

    static (int, int) FindSmallestElementAndRowIndex(int[,] matrix)
    {
        int min = int.MaxValue;
        int rowIndex = -1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    rowIndex = i;
                }
            }
        }
        return (min, rowIndex);
    }

    static int FindLargestOddNumber(int[,] matrix)
    {
        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max && matrix[i, j] % 2 != 0)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    static int[] CountEvenElementsInColumns(int[,] matrix)
    {
        int[] counts = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    counts[j]++;
                }
            }
        }
        return counts;
    }

    static int CountEvenNegativeElements(int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0 && matrix[i, j] % 2 == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    static int FindLargestElement(int[,] matrix)
    {
        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    static int FindSmallestEvenNumber(int[,] matrix)
    {
        int min = int.MaxValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min && matrix[i, j] % 2 == 0)
                {
                    min = matrix[i, j];
                }
            }
        }
        return min;
    }

    static int FindLargestMultipleOf3(int[,] matrix)
    {
        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max && matrix[i, j] % 3 == 0)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    static int FindColumnWithLargestNegativeCount(int[,] matrix)
    {
        int maxCount = int.MinValue;
        int columnIndex = -1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                columnIndex = j;
            }
        }
        return columnIndex;
    }

    static int FindColumnWithSmallestNegativeCount(int[,] matrix)
    {
        int minCount = int.MaxValue;
        int columnIndex = -1;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, j] < 0)
                {
                    count++;
                }
            }
            if (count < minCount)
            {
                minCount = count;
                columnIndex = j;
            }
        }
        return columnIndex;
    }

    static void SortColumnsAscending(int[,] matrix)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(0) - i - 1; k++)
                {
                    if (matrix[k, j] > matrix[k + 1, j])
                    {
                        int temp = matrix[k, j];
                        matrix[k, j] = matrix[k + 1, j];
                        matrix[k + 1, j] = temp;
                    }
                }
            }
        }
    }
}