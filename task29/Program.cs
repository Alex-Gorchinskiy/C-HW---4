// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Не совсем понял, что именно нужно сделать, сделал два варианта 

// int[] numbers = { 1, 2, 5, 7, 19 };

// Console.WriteLine("[" + string.Join(", ", numbers) + "]");



int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
array [i] = new Random().Next(0, 100);
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
