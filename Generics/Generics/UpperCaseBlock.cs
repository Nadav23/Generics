using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class UpperCaseBlock<T> : IBlock<string> 
    {
        public string Process(string input)
        {
            return input.ToUpper();
        }
    }
}
