using System;

namespace Tiempo.InterfaceSegregation.Violations
{
    public class Document { }

    public interface IMachine
    {
        void Print(Document document);

        void Fax(Document document);

        void Scan(Document document);
    }

    public class MultiFuctionalPrinter : IMachine
    {
        public void Fax(Document document)
        {
            //Do something
        }

        public void Print(Document document)
        {
            //Do something
        }

        public void Scan(Document document)
        {
            //Do something
        }
    }


    public class CompacPrinter : IMachine
    {
        public void Fax(Document document)
        {
            throw new Exception("It cant do it");
        }

        public void Print(Document document)
        {
            //Do something like old school
        }

        public void Scan(Document document)
        {
            throw new Exception("It cant do it");
        }
    }
}
