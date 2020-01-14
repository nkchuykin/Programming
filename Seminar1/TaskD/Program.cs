Susing System;

class MainClass
{
    public static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int coef1 = int.Parse(Console.ReadLine());
        int coef2 = int.Parse(Console.ReadLine());
        int prize = int.Parse(Console.ReadLine());
        Soldier s = new Soldier(start);
        Colonel c = new Colonel(coef1);
        General g = new General(coef2, prize);
        Console.WriteLine(s.GetSalary());
        Console.WriteLine(c.GetSalary());
        Console.WriteLine(g.GetSalary());
    }
}

