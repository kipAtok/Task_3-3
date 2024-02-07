using System;

class Program
{
    public static void Main(string[] args)
    {
        IArrBase[] arrs = new IArrBase[3];
        arrs[0] = new OneDimentionArr();
        arrs[1] = new TwoDimentionArr();
        arrs[2] = new LadderArr();

        foreach (var arr in arrs)
        {
            arr.Print();
            Console.WriteLine($"Avg: {arr.Avg}");
            arr.FillArr(true);
            arr.Print();
        }

        Printer printer = new Printer();
        IPrinter[] printable = new IPrinter[4];
        for (int i = 0; i < 3; i++)
        {
            printable[i] = arrs[i];
        }
        printable[3] = printer;

        foreach (var elem in printable)
        {
            elem.Print();
        }
    }
}