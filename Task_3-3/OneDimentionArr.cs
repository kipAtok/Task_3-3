using System;

class OneDimentionArr: ArrBase
{
    private int[] _myArr;

    public OneDimentionArr(bool userFill = false)
    {
        FillArr(userFill);
    }

    public override double Avg
    {
        get
        {
            double sum = 0;
            foreach (int num in _myArr)
            {
                sum += num;
            }
            return sum / _myArr.Length;
        }
    }

    public override void Print()
    {
        Console.WriteLine("Your array: ");
        foreach (int i in _myArr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public override void FillArr(bool userFill)
    {
        if (userFill)
        {
            ManualFill();
        }
        else
        {
            AutoFill();
        }
    }

    protected override void ManualFill()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        _myArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Enter a value of {i + 1} element: ");
            _myArr[i] = int.Parse(Console.ReadLine());
        }
    }

    protected override void AutoFill()
    {
        Random rnd = new Random();
        int length = rnd.Next(3, 10);
        _myArr = new int[length];
        for (int i = 0; i < length; i++)
        {
            _myArr[i] = rnd.Next(1, 10);
        } 
    }
}
