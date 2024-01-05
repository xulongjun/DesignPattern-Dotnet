using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Strategy
{
    // Strategy Interface
    // The Strategy Interface declare methods that are common to all supported versions of the algorithm.
    // The Context Object is going to use this Strategy Interface to call the algorithm defined by Concrete Strategies.
    public interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);
    }
}
