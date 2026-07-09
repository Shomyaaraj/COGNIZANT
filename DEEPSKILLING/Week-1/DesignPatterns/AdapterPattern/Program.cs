using System;

class OldPrinter
{
    public void PrintOld()
    {
        Console.WriteLine("Printing using old printer");
    }
}

interface IPrinter
{
    void Print();
}

class PrinterAdapter : IPrinter
{
    OldPrinter printer = new OldPrinter();

    public void Print()
    {
        printer.PrintOld();
    }
}

class Program
{
    static void Main()
    {
        IPrinter printer = new PrinterAdapter();
        printer.Print();
    }
}