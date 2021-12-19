using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer_Reflection
{
    public class MyList<T>
    {
        public MyList()
        {
            list = new T[10];
        }
        public T[] list;
        public static int count;
        public void Add(T value)
        {
            if (count != 0 && count % 10 == 0)
            {
                Array.Resize(ref list, list.Length + 10);
            }
            list[count] = value;
            count++;
        }
    }
}
