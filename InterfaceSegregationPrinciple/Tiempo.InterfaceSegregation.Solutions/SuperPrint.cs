using System;

namespace Tiempo.InterfaceSegregation.Solutions
{

    public class Document { }
    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            // Do something
        }
    }

    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            // Do something
        }

        public void Scan(Document d)
        {
            // Do something
        }
    }

    public interface IMultiFunctionDevice : IPrinter, IScanner
    {

    }

    public class MultiFunctionDevice : IMultiFunctionDevice
    {
        private readonly IPrinter _printer;
        private readonly IScanner _scanner;

        public MultiFunctionDevice(IPrinter printer, IScanner scanner)
        {
            _printer = printer;
            _scanner = scanner;
        }
        public void Print(Document d)
        {
            _printer.Print(d);
        }

        public void Scan(Document d)
        {
            _scanner.Scan(d);
        }
    }
}
