Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m,n];

for(int i = 0; i < array.GetLength(0); i++)
{
	for(int j = 0; j < array.GetLength(1); j++)
	{
		array[i,j] = new Random().Next(1, 100);
		Console.Write(array[i,j] + ", ");
	}
Console.WriteLine();
}


Averge(array);



void Averge(double[,] array)
{
	double[] result = new double[n];
	double[] srednArif = new double[n];
	for(int j = 0; j < array.GetLength(0); j++)
	{
		for(int i =0; i< array.GetLength(1); i++)
    	{
    		result[j] += array[i,j];
    	} 
    	srednArif[j] = result[j]/n;
		Console.Write($"среднее арифметическое {j +1} столба ровняется {srednArif[j]}");
    	Console.WriteLine();
	}

}