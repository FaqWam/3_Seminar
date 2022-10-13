Console.Write("Введите число: ");
string number = Console.ReadLine();
int lenght = number.Length;

if (lenght == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write("Палиндром");
    }
    else
    {
        Console.Write("Не палиндром");
    }
}
else
{
    Console.Write("Введте пятизначное число");
}