using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList1<T>
    {
        private T[] items = new T[4];
        private int count = 0;
        private int capacity;

        public CustomList1()
        {

        }


        public void Add(T item)
        {
            if (count == capacity)
            {
                count++;
            }
        }

        public void Remove(T item)
        {
            if (count >= capacity)
            {
                count--;
            }
        }
    }
}
