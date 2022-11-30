using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyDictionary<TKey, TValue>
    {
        private int counter = 0;
        private TKey[] keysArray = null;
        private TValue[] valsArray = null;

        public int Counter
        {
            get
            {
                return this.counter;
            }
        }

        public void Add(TKey key, TValue val)
        {
            this.counter++;

            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;

            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }

        public TValue this[TKey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
    }
}