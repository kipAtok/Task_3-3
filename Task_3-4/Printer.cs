using System;

class Printer: IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printer was called");
    }
}