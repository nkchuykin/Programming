using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Tree<int> tree = new Tree<int>();
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        foreach (int a in input)
            tree.Add(a);
        Tree<int> tree1 = (Tree<int>)tree.Clone();
        input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        foreach (int a in input)
            tree1.Add(a);
        Console.WriteLine(tree);
        Console.WriteLine(tree1);
    }
}
