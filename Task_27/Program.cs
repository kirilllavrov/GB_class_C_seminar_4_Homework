Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (numA > 0)
{
    sum = (numA % 10) + sum;
    numA = numA / 10;
}
Console.WriteLine(sum);