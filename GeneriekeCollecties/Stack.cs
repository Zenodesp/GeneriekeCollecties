using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriekeCollecties
{
    internal class Pile<T>
    {
        List<T> container;

        public void AddTo(T i)
        {
            container.Add(i);
        }

        public bool isLeeg()
        {
            return container.Count == 0;
        }

        public T RemoveFrom()
        {
            T even = container[0];
            container.RemoveAt(0);
            return even;
        }

        public void Clear()
        {
            container.Clear();
        }

        public override string ToString()
        {
            string s = "";
            foreach (T i in container)
            {
                s += i.ToString() + "\n";
            }
            return s;
        }


    }
}
