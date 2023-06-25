namespace TwoIndices;

public class Worker
{
    public Worker()
    {
        Work();
    }

    void Work()
    {
        var nums = new int[] { 2, 7, 11, 15 }; // 9
        Console.Write("Number they add to: ");
        var addToNumber = int.Parse(Console.ReadLine());
        // this is a new feature called Tuples
        (int firstNumber, int lastNumber) = TwoIndices(nums, addToNumber);
        Console.WriteLine("Here is numbers that add to the number you entered.");
        Console.WriteLine($"{firstNumber}, {lastNumber}");
    }

    (int , int) TwoIndices(int[] nums, int addToNumber)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums.Length - 1 && nums[i] + nums[i + 1] == addToNumber)
                return (nums[i], nums[i + 1]);
            continue;
        }
        return (0, 0);
    }
}