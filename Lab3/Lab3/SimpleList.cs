using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3
{
    public class SimpleList<T> : IEnumerable<T> where T : IComparable
    {
        protected SimpleListItem<T> first;
        protected SimpleListItem<T> last;
        
        public int count { get; protected set; }
        
        public void add(T element)
        {
            var newItem = new SimpleListItem<T>(element);
            count++;
           
            if (last == null)
            {
                first = newItem;
                last = newItem;
            }

            else
            {

                last.next = newItem;
                last = newItem;
            }
        }

       
        public SimpleListItem<T> getItem(int number)
        {
            if (number < 0 || number >= count)
            {
                throw new ArgumentOutOfRangeException("Выход за границу индекса");
            }

            var current = first;
            
            var i = 0;
            while (i < number)
            {
                current = current.next;
                i++;
            }

            return current;
        }


        public T Get(int number)
        {
            return getItem(number).data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = first;

            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void sort()
        {
            sort(0, count - 1);
        }

        private void sort(int low, int high)
        {
            int i = low;
            int j = high;
            T x = Get((low + high) / 2);
            do
            {
                while (Get(i).CompareTo(x) < 0) ++i;
                while (Get(j).CompareTo(x) > 0) --j;
                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (low < j) sort(low, j);
            if (i < high) sort(i, high);
        }

        private void swap(int i, int j)
        {
            SimpleListItem<T> ci = getItem(i);
            SimpleListItem<T> cj = getItem(j);
            T temp = ci.data;
            ci.data = cj.data;
            cj.data = temp;
        }
    }
}