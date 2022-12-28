using System;
using System.Collections.Generic;
using System.Text;

namespace Menutask2
{
    internal class NameFormatException:Exception
    {
        public NameFormatException(string message) : base(message)
        {

        }
    }
}
