using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ReverseBlock : IBlock<string>
    {
        public string Process(string input) 
        {
            char[] inputAsCharArray = input.ToCharArray();
            Array.Reverse(inputAsCharArray);
            return new string(inputAsCharArray);
        }
    }
}
