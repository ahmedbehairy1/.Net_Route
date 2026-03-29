using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    public class SafeList<T>
    {
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Get(int index)
        {
            if (index >= 0 && index < list.Count)
                return list[index];

            return default(T);
        }
    }
}
