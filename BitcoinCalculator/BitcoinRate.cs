using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinCalculator
{
    class BitcoinRate
    {
        public bpi bpi { get; set; }
        public string disclaimer { get; set; }
    }



    public class bpi
    {
        public USD USD { get; set; }
    }

    public class USD
    {
        public string code { get; set; }
        public float rate_float { get; set; }
    }
}
