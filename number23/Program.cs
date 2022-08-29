Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int a = 1;
while(a<=n)
{
    double res = Math.Pow(a,3);
    Console.WriteLine(res);
    a++;
}