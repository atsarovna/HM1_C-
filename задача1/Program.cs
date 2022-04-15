Console.Write("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());

//находим максимальное число
if (a > b)
{
    Console.WriteLine("Максимальное число: " + a);
    Console.WriteLine("Минимальное число: " + b);
}
else 
{
    Console.WriteLine("Максимальное число: " + b);
    Console.WriteLine("Минимальное число: " + a);
}

// программа,которая выдает какое из 2 чисел большее и меньшее