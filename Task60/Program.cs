Console.Clear();
Console.WriteLine("Введите размер трёхмерной матрицы: ");
int size = int.Parse (Console.ReadLine()!);
int [,,] matrix = new int [size, size, size];

for(int i = 0; i < size; i++)
{
    for(int n = 0; n < size; n++)
        {
            for(int h = 0; h< size; h++)
                {
                    matrix [i,n,h] = new Random().Next(0, 100);
                    Console.Write($"{matrix[i,n,h]} ({i},{n},{h}) ");
                }
   
     }
Console.WriteLine();
}
