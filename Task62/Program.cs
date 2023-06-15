Console.Clear();
int num = 1;
int n = 0;
int i = 0;


Console.WriteLine("Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine()!);
int [,] matrix = new int [size, size];

while (num <= size*size)
{
    matrix [i,n] = num;
    if (i <= n+1 && i+n < size-1)
        n++;
    else if (i < n && i + n>= size-1)
        i++;
    else if (i >= n && i + n > size -1)
        n--;
    else
        i--;
    num++;
}

for (int z = 0; z < size; z++)
    {
        for (int v = 0; v < size; v++)
            {
                Console.Write($"{matrix[z,v]} ");
            }
        Console.WriteLine();
    }