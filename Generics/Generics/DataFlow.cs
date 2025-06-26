using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DataFlow<T> : IDataFlow<T> where T : class
    {
        public List<IBlock<T>> Flow { get; set; }

        public DataFlow()
        {
            Flow = new List<IBlock<T>>();
        }

        public T RunFlow(T input)
        {
            if (input == null)
            {
                return null;
            }

            foreach (IBlock<T> block in Flow)
            {
                 input = block.Process(input);
            }

            return input;

        }

        public void AddBlock(IBlock<T> block)
        {
            Flow.Add(block);

        }
    }

}
