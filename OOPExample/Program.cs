using OOPExample;
using System;


namespace ComplexOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powButt = new PowerButton(TV); // we know that we work for TV device

            powButt.Execute();
            powButt.Undo();

            powButt.Execute();
            powButt.Undo();
        }
    }
}
