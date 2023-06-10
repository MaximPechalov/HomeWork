Console.Clear();


Console.WriteLine("Введите перввое число: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}

Console.WriteLine(max);