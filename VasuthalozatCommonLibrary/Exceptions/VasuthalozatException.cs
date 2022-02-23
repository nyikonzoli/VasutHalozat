using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasuthalozatCommonLibrary.Exceptions
{
    public class VasuthalozatException : Exception
    {
        public VasuthalozatException(string exc) : base(exc)
        {
        }
    }
}
