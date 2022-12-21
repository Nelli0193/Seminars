Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int OneNumber = 2;

if(number > 1)
{
    while(OneNumber <= number)
    {
        Console.Write(OneNumber + " ");
        OneNumber = OneNumber + 2;
    }
}
