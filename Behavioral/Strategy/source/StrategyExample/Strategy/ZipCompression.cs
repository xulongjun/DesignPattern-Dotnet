using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Strategy
{
    // Concrete Strategy B
    // The following ZipCompression Concrete Strategy implement the Strategy Interface and 
    // Implement the CompressFolder Method. 
    public class ZipCompression : ICompression
    {
        public string? MessageTest { get; private set; }
        public void CompressFolder(string compressedArchiveFileName)
        {
            MessageTest = $"Folder is compressed using zip approach: '{compressedArchiveFileName}.rar' file is created";
            Console.WriteLine(MessageTest);
        }
    }
}
