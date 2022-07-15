/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа. 
456 -> 5; 782 -> 8; 918 -> 1  */

int number = new Random().Next (100, 1000);
int secondDigit = (number / 10) % 10;
Console.Write (number + " - " + secondDigit); 



/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет. */

void findThirdDigit (int x)
{
    int div = 1;
    while (x / div >= 10)
    {
        div *= 10;
    }

    if (div < 100) Console.WriteLine ("Третьей цифры нет");
    else 
    {
        int digit = (x / (div/100)) % 10;
        Console.WriteLine ("Третья цифра - {0}", digit);
    }
}

findThirdDigit (358);
findThirdDigit (25);
findThirdDigit (1045); 



/* Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным */

string[] weekday = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
Console.WriteLine ("Введите целое число от 1 до 7");
int number = Convert.ToInt32 (Console.ReadLine());

if (number == 6 || number == 7) Console.WriteLine ("Это выходной день");
else Console.WriteLine ("Это рабочий день");