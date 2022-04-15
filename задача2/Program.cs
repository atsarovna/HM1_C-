Console.WriteLine("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число :");
int c = Convert.ToInt32(Console.ReadLine());

//назначаем одно число максимальным и сравниваем с другими числами
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
//программа,котрорая выдает максимальное число из трех введенных