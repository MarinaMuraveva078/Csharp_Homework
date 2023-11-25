// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
Console.WriteLine(text);
return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void PrintSummNumbers(int startNumber, int stopNumber, int summ)
{
summ = summ + startNumber;
if (startNumber > stopNumber) return;
Console.WriteLine(summ);
PrintSummNumbers(startNumber + 1, stopNumber, summ);
}

int M = ReadInt("Введите число M:");
int N = ReadInt("Введите число N:");
Console.WriteLine();
int summ = 0;

if (M>N)
{
   Console.WriteLine("Значение M больше значения N");
   return;
}

PrintSummNumbers(M,N,summ);
