using System;

interface IPrinter
{
    public void Print(string message);
}


interface IArrBase
{
    public int Avg { get; }

    public void FillArr(bool userFill = false) 
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

    protected void ManualFill() { }

    protected void AutoFill() { } 
}