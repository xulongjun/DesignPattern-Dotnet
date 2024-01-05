﻿using StrategyExample.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample.Context
{
    // The Context Provides the interface which is going to be used by the Client.
    public class CompressionContext
    {
        // The Context has a reference to one of the Strategy objects. 
        // The Context does not know the concrete class of a strategy. 
        // It should work with all strategies via the Strategy interface.
        private ICompression Compression;
        //Initializing the Strategy Object i.e. Compression using Constructor
        public CompressionContext(ICompression Compression)
        {
            // The Context accepts a strategy through the constructor, 
            // but also provides a setter method to change the strategy at runtime
            this.Compression = Compression;
        }
        //The Context allows replacing a Strategy object at runtime.
        public void SetStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }
        // The Context delegates the work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void CreateArchive(string compressedArchiveFileName)
        {
            //The CompressFolder method is going to be invoked based on the strategy object
            Compression.CompressFolder(compressedArchiveFileName);
        }
    }
}
