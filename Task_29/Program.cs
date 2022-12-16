Console.WriteLine($"Введите длину массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[num];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = new Random().Next(1, 100);
}

for (int i = 0; i < nums.Length; i++)
{
    Console.Write($"{nums[i]}, ");

}

Console.WriteLine();