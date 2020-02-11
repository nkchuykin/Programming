
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
		try
		{
			TaskList todoList = new TaskList();
			for (int i = 0; i < n; i++)
			{
				todoList.Add(Task.Parse(Console.ReadLine()));
			}
			todoList.Do();
		}
		catch (FormatException ex)
		{
			Logger.GetLogger().Write(ex.Message);
		}
	}
}

