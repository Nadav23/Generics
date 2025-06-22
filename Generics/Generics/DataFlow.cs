using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DataFlow<T> : IDataFlow<T> where T : class
    {
        public List<IBlock<T>> flow;
        public T RunFlow(T input)
        {
            T output = input;

            foreach (IBlock<T> block in flow)
            {
                output = block.Process(input);

            }

            return output;

        }

        public void AddBlock(IBlock<T> block)
        {
            flow.Add(block);

        }
    }

}
