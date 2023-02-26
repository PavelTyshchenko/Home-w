//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a1 = 5;
int b1 = 7;

int a2 = 2;
int b2 = 10;

int a3 = -9;
int b3 = -3;

int max1 = a1;
if (b1 > max1) max1 = b1; 

Console.WriteLine(max1);

int max2 = a2;
if (b2 > max2) max2 = b2; 

Console.WriteLine(max2);

int max3 = a3;
if (b3 > max3) max3 = b3; 

Console.WriteLine(max3);


