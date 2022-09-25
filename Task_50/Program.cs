Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату элемента по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату элемента по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];
void Array(int[,] matrix)
{
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(0,100);
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Array(matrix);
Console.WriteLine();
if (x < n || y < m)
    Console.WriteLine("Число -> " + matrix[x - 1, y - 1]);
else
    Console.Write(" -> такого числа нет");