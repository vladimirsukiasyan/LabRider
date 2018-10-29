using System;

namespace Lab3
{
    class SimpleStack<T> : SimpleList<T> where T : IComparable
    {
        public void push(T element)
        {
            add(element);
        }
        public T pop()
        {
            var result = default(T);
            if (count == 0) return result;
            if (count == 1)
            {
                result = first.data;
                first = null;
                last = null;
            }
            else
            {
                var newLast = getItem(count - 2);
                result = newLast.next.data;
                last = newLast;
                newLast.next = null;
            }
            count--;
            return result;
        }
    }
}