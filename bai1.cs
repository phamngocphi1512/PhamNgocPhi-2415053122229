using System;

class Bai1
{
    public static void Run()
    {
        Console.Write("Nhap ho ten: ");
        string hoTen = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(hoTen))
        {
            Console.WriteLine("Chuoi rong hoac null");
            return;
        }

        hoTen = hoTen.Trim();

        string[] arr = hoTen.Split(
            new char[] { '
            ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        string ketQua = "";

        foreach (string tu in arr)
        {
            string tuChuanHoa =
                char.ToUpper(tu[0]) + tu.Substring(1).ToLower();
            ketQua += tuChuanHoa + " ";
        }

        Console.WriteLine("Ho ten sau chuan hoa: " + ketQua.Trim());
    }
}
