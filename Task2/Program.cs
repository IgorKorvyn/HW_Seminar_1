Console.Write("Введите первое число: "); 
int первое_число = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: "); 
int второе_число = Convert.ToInt32(Console.ReadLine()); 
if (первое_число > второе_число) {
    Console.Write("Максимальное число:");
    Console.WriteLine(первое_число);
    Console.Write("Минимальное число:");
    Console.WriteLine(второе_число);
}
else {
    Console.Write("Максимальное число:");
    Console.WriteLine(второе_число);
    Console.Write("Минимальное число:");
    Console.WriteLine(первое_число);
}