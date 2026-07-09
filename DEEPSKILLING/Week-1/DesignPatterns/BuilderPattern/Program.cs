using System;

class Computer
{
    public string CPU;
    public string RAM;

    public void Show()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"RAM: {RAM}");
    }
}

class ComputerBuilder
{
    Computer computer = new Computer();

    public void SetCPU()
    {
        computer.CPU = "Intel i5";
    }

    public void SetRAM()
    {
        computer.RAM = "16 GB";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

class Program
{
    static void Main()
    {
        ComputerBuilder builder = new ComputerBuilder();

        builder.SetCPU();
        builder.SetRAM();

        Computer computer = builder.GetComputer();

        computer.Show();
    }
}