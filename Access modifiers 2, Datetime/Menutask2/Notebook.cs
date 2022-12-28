using System;
using System.Collections.Generic;
using System.Text;

namespace Menutask2
{
    public class Notebook:Product
    {
        public Notebook(string name, double price) : base(name, price)
        {

        }

        public Notebook(string name, double price, byte ram) : base(name, price)
        {
            this.Ram = ram;
        }
        public byte Ram;
    }
}
