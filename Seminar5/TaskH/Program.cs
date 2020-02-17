using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] nums = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int j = 0; j < 3; j++)
                nums[i, j] = line[j];
        }
        Game game = new Game(nums);
        Console.WriteLine(game.Solution());
    }
}
