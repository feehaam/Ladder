using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder._15._Generics.Advanced_Generics
{
    public class MyDictionary<TKey, TValue>
    {
        private List<MyKeyValuePair<TKey, TValue>> items = new List<MyKeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            MyKeyValuePair<TKey, TValue> pair = new MyKeyValuePair<TKey, TValue>(key, value);
            items.Add(pair);
        }

        public TValue this[TKey key]
        {
            get
            {
                MyKeyValuePair<TKey, TValue> pair = items.Find(p => p.Key.Equals(key));
                if (pair == null)
                    throw new KeyNotFoundException();
                else
                    return pair.Value;
            }
            set
            {
                MyKeyValuePair<TKey, TValue> pair = items.Find(p => p.Key.Equals(key));
                if (pair == null)
                {
                    pair = new MyKeyValuePair<TKey, TValue>(key, value);
                    items.Add(pair);
                }
                else
                {
                    pair.Value = value;
                }
            }
        }

        private class MyKeyValuePair<TKey, TValue>
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }

            public MyKeyValuePair(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }
        public static void Play()
        {
            MyDictionary<int, string> myDict = new MyDictionary<int, string>();

            myDict.Add(1, "First");
            myDict.Add(2, "Second");
            myDict.Add(3, "Third");

            Console.WriteLine("Dictionary values:");
            foreach (int key in new List<int>() { 1, 2, 3 })
            {
                Console.WriteLine($"Key: {key}, Value: {myDict[key]}");
            }

            myDict[2] = "New Second Value";

            Console.WriteLine("Dictionary values after updating value at key 2:");
            foreach (int key in new List<int>() { 1, 2, 3 })
            {
                Console.WriteLine($"Key: {key}, Value: {myDict[key]}");
            }

            try
            {
                string value = myDict[4];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine("Key not found in dictionary.");
            }
        }

    }
}
