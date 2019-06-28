using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> boxes = new List<T>();

        public int Count => boxes.Count();

        public void Add(T element)
        {
            boxes.Add(element);
        }

        public T Remove()
        {
            if (Count > 0)
            {
                T lastElement = boxes.Last();

                boxes.RemoveAt(Count - 1);

                return lastElement;
            }

            throw new InvalidOperationException("Can not remove");
        }
    }
}
