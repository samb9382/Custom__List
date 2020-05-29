using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList<T>
    {




        public T[] items = new T[5];

        public CustomList()
        {
            count = 0;
            capacity = 0;
        }
        private int count;
        private int capacity;


        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        public T this[int number]
        {
            get
            {
                // This is invoked when accessing Layout with the [ ].
                if (number >= 0 && number < items.Count)
                {
                    // Bounds were in range, so return the stored value.
                    return items[number];
                }
                // Return an error string.
                return "Error";
            }
            set
            {
                // This is invoked when assigning to Layout with the [ ].
                if (number >= 0 && number < items.count)
                {
                    // Assign to this element slot in the internal array.
                    items[number] = value;
                }
            }
        }






        public void Add(T item)//Add method
        {
            items[count] = item;
            count++;

            if (count == capacity)
            {
                capacity++;
                
            }
            
            //Adding to new array
            //if count and capacity are equal
            //increace capacity
        }

        public void Remove(T item)//Remove method
        {
            items[count] = item;
            count--; //remove item from array
            if (count >= capacity)
            {
                count--;
            }
        }
    }
}


