using System;

interface IPrinter
{
    public void Print();
}

interface IArrBase: IPrinter
{
    public double Avg { get; }
    
    public void FillArr(bool userFill);
}

interface IOneDimentionArr: IArrBase, IPrinter
{
    public int[] Uniq { get; }
}

interface ITwoDimentionArr: IArrBase, IPrinter
{
    public void PrintSnake();
}

interface ILAdderArr: IArrBase, IPrinter
{
    public int[][] WithEveryEvenToIndexProduct { get; }
}
