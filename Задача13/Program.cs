//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int value = 78;


if (value >= 100)
{
     while (value > 999)
                {
                    value = value / 10;
                }
int c = value % 10;
int result = c;
Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Третьей цифры нет"); 
}
