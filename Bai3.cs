using System;

class Bai3
{
    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(s))
        {
            Console.WriteLine("Chuoi khong doi xung");
            return;
        }

        s = s.Replace(" ", "").ToLower();

        int left = 0;
        int right = s.Length - 1;

        bool doiXung = true;

        while (left < right)
        {
            if (s[left] != s[right])
            {
                doiXung = false;
                break;
            }
            left++;
            right--;
        }

        if (doiXung)
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");
    }
}