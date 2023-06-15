Console.Clear();
int temp = 0;

//Initially generating a matrix
Console.Write("Введите размер матрицы: ");
int size = int.Parse(Console.ReadLine()!);
int [,] matrix = new int [size, size];
Console.WriteLine("Изначальная матрица: ");
for (int i = 0; i < size; i++)
{
    for (int n = 0; n < size; n++)
        {
            matrix[i,n] = new Random().Next(0, 100);
            Console.Write($"{matrix [i,n]} ");
        }
Console.WriteLine();
}
//Organising the matrix in the descending order
for (int z = 0; z < size; z++)
{
    for (int v = 0; v< size; v++)
    {
        for (int o = 0; o < size-1; o++)
        {
            if (matrix [z,o] < matrix[z,o+1])
            {
            temp = matrix [z, o+1];
            matrix [z, o+1]= matrix [z, o];
            matrix [z, o] = temp;
            }
                       
        }         
    }
}
//displaying the final matrix

Console.WriteLine();
Console.WriteLine("Отсортированная матрица: ");
for (int i = 0; i < size; i++)
{
    for (int n = 0; n < size; n++)
        {
            Console.Write($"{matrix [i,n]} ");
        }
Console.WriteLine();
}