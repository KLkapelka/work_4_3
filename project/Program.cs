// Дан файл numsTask3.txt с целыми числами, расположенными через «,». Переберите все числа до 0.
// Определите отношение минимального и максимального элементов друг к другу;

using System;
using System.IO;
class work_4_3
{
    static void Main()
    {
        string fael = "numsTask3.txt"; 
        string[] faelNumbers = File.ReadAllText(fael).Split(','); 
        int[] nums = faelNumbers.Select(int.Parse).ToArray(); 
        int max = nums[0];
        int min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                Console.WriteLine(min);
                Console.WriteLine(max);
                Console.WriteLine($"Отношение минимального ({min}) к макисмальному ({max}) = {((float)min / (float)max)}"); // вывод
                break;
            }
            else if (nums[i] > max)
            {
                max = nums[i];
            }
            else if (nums[i] < min)
            {
                min = nums[i];
            }
        }
    }
}       