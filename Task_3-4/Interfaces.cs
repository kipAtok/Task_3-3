using System;

interface IPrinter
{
    public void Print();
}

interface IArrBase
{
    public double Avg { get; }
    public void FillArr(bool userFill = false);
}