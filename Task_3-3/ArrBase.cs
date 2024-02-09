using System;

abstract class ArrBase: IArrBase, IPrinter
{
    public abstract double Avg { get; }

    public virtual void FillArr(bool userFill)
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

    public abstract void Print();

    protected abstract void ManualFill();

    protected abstract void AutoFill();
}