// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetNumber(string message)
{
    int result;
    Console.WriteLine(message);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out int number) && number > 0)
        {
            return number;
        }
        else
        Console.WriteLine("Вы ввели не положительное число число");
    }
    return result;
}
void Cube(int n)
{
    for(int i = 1; i <= n; i++)
    {
        if(i!=n)
        Console.Write($"{i*i*i}, ");
        else 
        Console.Write($"{i*i*i} ");
    }
}

int number = GetNumber("Введите положительное число:");
Cube(number);