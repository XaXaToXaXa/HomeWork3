// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// Console.WriteLine("Введите пятизначное число:");
// string? number = Console.ReadLine();

// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи ПЯТИзначное число");

Console.WriteLine("Введите пятизначное число:");
int Num = int.Parse(Console.ReadLine());
int Temp = Num;
int Rev = 0;
while (Temp > 0)
{
    Rev *= 10;
    Rev += Temp % 10;
    Temp /= 10;
}
if (Rev == Num)
{
     Console.WriteLine("О чудо это палиндром!");
}
else 
{
    Console.WriteLine("Это обычное число, чуда не будет.");
}