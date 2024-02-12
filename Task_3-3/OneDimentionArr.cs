using System;

class OneDimentionArr: ArrBase, IOneDimentionArr
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

    public int[] Uniq
    {
        get
        {
            int[] uniqArr = new int[_myArr.Length];
            int uniqAmount = 1;
            uniqArr[0] = _myArr[0];
            for (int i = 1; i < _myArr.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < i; j++)
                {
                    if (_myArr[i] == _myArr[j])
                    {
                        found = false;
                        break;

                    }
                }
                if (found)
                {
                    uniqArr[uniqAmount++] = _myArr[i];
                }
            }
            return uniqArr;
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