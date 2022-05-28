
Console.Write("Введите числа через пробел : ");
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0) count +=1;
}
Console.WriteLine($"Вы ввели {count} чисел, больших нуля");