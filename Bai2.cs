using System;

class Bai2
{
    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("So tu: 0");
            return;
        }

        s = s.Trim();

        string[] arr = s.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        Console.WriteLine("So tu: " + arr.Length);
    }
}