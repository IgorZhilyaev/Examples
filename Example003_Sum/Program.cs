int numberA = new Random().Next(1,10); // 1 2 3 ... 9
Console.Write("Первое случайное число: ");
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.Write("Второе случайное число: ");
Console.WriteLine(numberB);
Console.Write("Сумма этих чисел: ");
int result = numberA + numberB;
Console.WriteLine(result);
