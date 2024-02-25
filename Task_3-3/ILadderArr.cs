using System;

interface ILadderArr: IArrBase, IPrinter
{
    public int[][] WithEveryEvenToIndexProduct { get; }
}
