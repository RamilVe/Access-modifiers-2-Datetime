using System;
using System.Collections.Generic;
using System.Text;

namespace Menu_task
{
    internal class NameFormatException:Exception
    {
        public NameFormatException(string message):base(message) 
        {

        }
    }
}
