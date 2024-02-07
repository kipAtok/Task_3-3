using System;

abstract class ArrBase: IArrBase, IPrinter
{
    public abstract double Avg { get; }

    public abstract void FillArr(bool userFill = false);

    public abstract void Print();

    protected abstract void AutoFill();

    protected abstract void ManualFill();
}