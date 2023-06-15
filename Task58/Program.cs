Console.Clear();

//Variables


//Creating the matrixes
Console.Write("Введите размер матриц: ");
int size = int.Parse(Console.ReadLine()!);
int [,] matrix1 = new int [size, size];
int [,] matrix2 = new int [size, size];

//Displaying Matrix1
Console.WriteLine("Первая матрица: ");
for (int i = 0; i < size; i++)
    {
        for (int n = 0; n < size; n++)
            {
                matrix1 [i,n] = new Random().Next(0, 100);
                Console.Write($"{matrix1[i,n]} ");
            }
    Console.WriteLine();
    }

//Displaying Matrix2
Console.WriteLine("Вторая матрица: ");
for (int i = 0; i < size; i++)
    {
        for (int n = 0; n < size; n++)
            {
                matrix2 [i,n] = new Random().Next(0, 100);
                Console.Write($"{matrix1[i,n]} ");
            }
    Console.WriteLine();
    }
    
//Calculaling the final matrix

int [,] result_matrix = new int [size, size];

Console.WriteLine("Произведение матриц: ");
for (int i = 0; i < size; i++)
    {
        for (int n = 0; n < size; n++)
            {
                result_matrix [i,n] = matrix1[i,n]*matrix2[i,n];
                Console.Write($"{result_matrix[i,n]} ");
            }
    Console.WriteLine();
    }