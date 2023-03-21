// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// // функция сумма чисел от M до N
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }


Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);