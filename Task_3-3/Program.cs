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

        arrs[0].Print();
        Console.WriteLine("Uniq values: ");
        foreach (int i in ((IOneDimentionArr)arrs[0]).Uniq)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        arrs[1].Print();
        ((ITwoDimentionArr)arrs[1]).PrintSnake();

        arrs[2].Print();
        int[][] ldTemp = ((ILadderArr)arrs[2]).WithEveryEvenToIndexProduct;
        Console.WriteLine("Your ladder array with every even value converted to it's index product: ");
        foreach (int[] line in ldTemp)
        {
            foreach (int num in line)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}