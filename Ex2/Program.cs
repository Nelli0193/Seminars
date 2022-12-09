// Задача 15

Console.WriteLine("Hello, World!");
Console.Clear();

Console.Write("Узнать выходной день! ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 1 && n <=5)
{
    Console.Write("Это не выходной!");
}
else if (n >=6 && n <=7)
{
    Console.Write("Ура, выходной день!");
}
else Console.Write("Нет такого дня недели.");
