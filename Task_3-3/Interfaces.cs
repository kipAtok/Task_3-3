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