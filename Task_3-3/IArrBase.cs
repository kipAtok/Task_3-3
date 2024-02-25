using System;

interface IArrBase: IPrinter
{
    public double Avg { get; }
    
    public void FillArr(bool userFill);
}