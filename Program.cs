Console.WriteLine("Задача 10");
 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int a = 456;
int b = 782;
int c = 918;
int a1 = a / 10;
int a2 = a1 % 10;
Console.WriteLine ($"{a2}");
int b1 = b / 10;
int b2 = b1 % 10;
Console.WriteLine ($"{b2}");
int c1 = c / 10;
int c2 = c1 % 10;
Console.WriteLine ($"{c2}");

int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number)); 
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a4)
{
    
    int result = ((a4 / 10) % 10);
    return result;
}