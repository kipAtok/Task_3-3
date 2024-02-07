using System;

class TwoDimentionArr: ArrBase
{
    private int[,] _myArr;

    public TwoDimentionArr(bool userFill = false)
    {
        FillArr(userFill);
    }

    public override double Avg
    {
        get
        {
            double sum = 0;
            for (int i = 0; i < _myArr.GetLength(0); i++)
            {
                for (int j = 0; j < _myArr.GetLength(1); j++)
                {
                    sum += _myArr[i, j];
                }
            }
            return sum / _myArr.Length;
        }
    }

    public override void Print()
    {
        Console.WriteLine("Your two dimention array: ");
        for (int i = 0; i < _myArr.GetLength(0); i++)
        {
            for (int j = 0; j < _myArr.GetLength(1); j++)
            {
                Console.Write(_myArr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public override void FillArr(bool userFill = false)
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
        Console.Write("Enter the depth of the array: ");
        int depth = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of every nested array: ");
        int length = int.Parse(Console.ReadLine());
        _myArr = new int[depth, length];
        for (int i = 0; i < depth; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write($"Enter a value of {j + 1} element of {i + 1} line: ");
                _myArr[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    protected override void AutoFill()
    {
        Random rnd = new Random();
        int depth = rnd.Next(3, 10);
        int length = rnd.Next(3, 10);
        _myArr = new int[depth, length];
        for (int i = 0; i < depth; i++)
        {
            for (int j = 0; j < length; j++)
            {
                _myArr[i, j] = rnd.Next(1, 10);
            }
        }
    } 
}