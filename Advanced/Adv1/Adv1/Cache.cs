using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    public class Cache<TKey, TValue>
    {
        private Dictionary<TKey, (TValue value, DateTime expire)> data
        = new Dictionary<TKey, (TValue, DateTime)>();

        public void Add(TKey key, TValue value, int seconds)
        {
            data[key] = (value, DateTime.Now.AddSeconds(seconds));
        }

        public TValue Get(TKey key)
        {
            if (data.ContainsKey(key))
            {
                var item = data[key];

                if (DateTime.Now < item.expire)
                    return item.value;

                data.Remove(key);
            }

            return default(TValue);
        }

        public void Remove(TKey key)
        {
            data.Remove(key);
        }

        public bool Contains(TKey key)
        {
            return data.ContainsKey(key);
        }
    }
}
