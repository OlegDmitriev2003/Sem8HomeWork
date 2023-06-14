Console.Clear();
//Variables
int sum = 0;
int MinSum = 1000000;
int MinRow = 0;

//Creating a matrix

Console.Write("Введите размер матрицы: ");
int rows = int.Parse(Console.ReadLine()!);
int collumns = rows + 1;
int [,] matrix = new int [rows, collumns];

//Filling the matrix with numbers and displaying it
for (int i = 0; i < rows; i++)
    {
        for (int n = 0; n<collumns; n++)
            {
                matrix [i, n] = new Random().Next(0, 100);
                Console.Write($"{matrix[i,n]} ");
            }
    Console.WriteLine();
    }

//Calculating row sums

for (int z = 0; z < rows; z++)
{
    for (int v = 0; v < collumns; v++)
        {
        sum = sum + matrix[z,v];
        }
//Finding the smallest sum and it's corresponding row
if (sum < MinSum)
{
MinSum = sum;
MinRow = z;
}
sum = 0;
    
}

//Output

Console.WriteLine($"Наименьшая сумма чисел содержится в ряду {MinRow}");