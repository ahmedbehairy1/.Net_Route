using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    public class Container<T>
    {
        private T item;

        public void Add(T value)
        {
            item = value;
        }

        public T Get()
        { 
            return item;
        }
    }
}
