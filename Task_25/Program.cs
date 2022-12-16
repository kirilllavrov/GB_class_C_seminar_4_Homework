Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numD = 1;


// Вариант 1
int i = 0;

while (i<numB)
{
numD = numD * numA;
i++;
}

Console.WriteLine(numD);


// Вариант 2
for (int i = 0; i < numB; i++)
{
    numD = numD * numA;
}

Console.WriteLine(numD);