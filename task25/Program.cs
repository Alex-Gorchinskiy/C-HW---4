// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree(int numberA, int numberB)
 {
     int result = 1;
     for (int i = 1; i <= numberB; i++)
     {
         result = result * numberA;
     }
     return result;
 }

 int GetInput(string text)
 {
     Console.Write(text);
     return Convert.ToInt32(Console.ReadLine());    
 }

 int numberA = GetInput("Введите число А: ");
 int numberB = GetInput("Введите число B: ");
 int result = GetDegree(numberA, numberB);
 Console.WriteLine($"Натуральная степень числа {numberA} в степени {numberB} равно {result}");