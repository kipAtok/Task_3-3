using System;

class LadderArr: ArrBase
{
    private int[][] _myArr;

    public LadderArr(bool userFill = false)
    {
        FillArr(userFill);
    }

    public override double Avg
    {
        get
        {
            double sum = 0;
            foreach (int[] line in _myArr)
            {
                foreach (int num in line)
                {
                    sum += num;
                }
            }
            return sum / _myArr.Length;
        }
    }

    public override void Print()
    {
        Console.WriteLine("Your ladder array: ");
        foreach (int[] line in _myArr)
        {
            foreach (int num in line)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    protected override void ManualFill()
    {
        Console.Write("Enter the depth of the array: ");
        int depth = int.Parse(Console.ReadLine());
        _myArr = new int[depth][];
        for (int i = 0; i < depth; i++)
        {
            Console.Write($"Enter the length of {i + 1} line: ");
            _myArr[i] = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < _myArr[i].Length; j++)
            {
                Console.Write($"Enter a value of {j + 1} element of {i + 1} line: ");
                _myArr[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    protected override void AutoFill()
    {
        Random rnd = new Random();  
        int depth = rnd.Next(3, 10);
        _myArr = new int[depth][];
        for (int i = 0; i < depth; i++)
        {
            _myArr[i] = new int[rnd.Next(1, 10)];
            for (int j = 0; j < _myArr[i].Length; j++)
            {
                _myArr[i][j] = rnd.Next(1, 10);
            }
        }
    }
}