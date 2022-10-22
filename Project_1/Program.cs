// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int GetNumber(string message)
{
    int result;
    Console.WriteLine(message);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out int number) && number > 9999 && number < 100000)
        {
            return number;
        }
        else
        Console.WriteLine("Вы ввели не пятизначное число");
    }
    return result;
}
void Palindrom(int number)
{
int leftPart = number/ 1000;
int rightPart = number % 100;
int reverseRightPart = ((rightPart%10)*10) + (rightPart/10);
if(leftPart == reverseRightPart) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} НЕ является палиндромом");
}

int number = GetNumber("Введите пятизначное число:");
Palindrom(number);