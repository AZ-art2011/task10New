//task 10

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(((num % 100)/10)%10);