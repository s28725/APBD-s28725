using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DangerousLoadException : Exception
    {
        public DangerousLoadException(string message) : base(message)
        {
        }
    }
}
