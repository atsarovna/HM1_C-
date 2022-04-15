Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());//конечное значение
int a = -b; //начальное значение

while (a <= b)
{
    Console.Write(a);
    a++;
if (a <= b)
{
    Console.Write(", ");
}
}
