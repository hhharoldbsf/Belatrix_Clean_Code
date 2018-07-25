using System;

namespace SOLID._04_Interface_Segregation
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
    }


    public interface IScanTasks
    {
        bool ScanContent(string content);
    }

    public interface IPhotoCopyTasks
    {
        bool PhotoCopyContent(string content);
    }

    public interface IFaxTasks
    {
        bool FaxContent(string content);
    }

    public interface IPrintDuplex : IPrintTasks
    {
        bool PrintDuplexContent(string content);
    }

    public class HPLaserJet : IPhotoCopyTasks, IFaxTasks, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }

    public class CannonMG2470 : IPrintTasks, IPhotoCopyTasks, IScanTasks
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}
