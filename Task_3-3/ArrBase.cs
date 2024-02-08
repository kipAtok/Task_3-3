using System;

abstract class ArrBase: IArrBase, IPrinter
{
    public abstract double Avg { get; }

    public abstract void FillArr(bool userFill);

    public abstract void Print();

    protected abstract void ManualFill();

    protected abstract void AutoFill();
}