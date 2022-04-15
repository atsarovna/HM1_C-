Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());//конечное значение
int a = 2; //начальное значение,потому что четные

while (a <= b)
{
    Console.Write(a + ", ");
    a+=2; //+2,тк четные
}
//программа показывает все четные от 1 до N