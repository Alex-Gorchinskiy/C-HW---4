// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number /= 10;
    }
    return sum;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = GetInput("Введите последовательность чисел: ");
int number = Math.Abs(number1);
Console.WriteLine($"Сумма всех чисел в последовательности {number} = {DigitSum(number)}");