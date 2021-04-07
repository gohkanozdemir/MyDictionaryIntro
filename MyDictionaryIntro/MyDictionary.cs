using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryIntro
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            bool isExist = ContainsKey(key);
           
            if (!isExist)
            {
                TKey[] tempKey = keys;
                TValue[] tempValue = values;

                keys = new TKey[keys.Length + 1];
                values = new TValue[values.Length + 1];

                for (int i = 0; i < tempKey.Length; i++)
                {
                    keys[i] = tempKey[i];
                    values[i] = tempValue[i];
                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
            }
            else
            {
                Console.WriteLine("Ayni" + key + " degerine sahip kayit oldugundan eklenmedi.");
            }
           
        }
        public bool ContainsValue(TValue value)
        {
            bool result=false;
            foreach (TValue item in values)
            {
                result = (item.ToString() == value.ToString()) ? true : false;
            }
            return result;
        }

        public bool ContainsKey(TKey key)
        {
            bool result = false;
            foreach (TKey item in keys)
            {
                result = (item.ToString() == key.ToString()) ? true : false;
            }
            return result;
        }
        public void Clear()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public TKey[] GetKeys
        {
            get { return keys; }
        }
        public TValue[] GetValues
        {
            get { return values; }
        }
    }
}
