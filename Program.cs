using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("1. Bai 1 - Chuan hoa ho ten");
        Console.WriteLine("2. Bai 2 - Dem so tu");
        Console.WriteLine("3. Bai 3 - Kiem tra doi xung");
        Console.Write("Chon bai: ");

        string chon = Console.ReadLine();

        Console.Clear();

        switch (chon)
        {
            case "1":
                Bai1.Run();
                break;
            case "2":
                Bai2.Run();
                break;
            case "3":
                Bai3.Run();
                break;
            default:
                Console.WriteLine("Lua chon khong hop le");
                break;
        }

        Console.ReadLine();
    }
}