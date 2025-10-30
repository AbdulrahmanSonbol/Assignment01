using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class FixedSizeList<T>
    {
        #region Atrribute

        private T[] items;

        private int count;

        private int capacity;
        #endregion

        #region Para const

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                Console.WriteLine("Capacity must be greater than zero");
                capacity = 1;
            }
           
            this.capacity = capacity;
            this.items = new T[capacity];
            this.count = 0;
        }

        #endregion

        #region Methods 

        #region Add

        public void Add(T item)
        {
            if (count >= capacity)
            {
                Console.WriteLine("The list is full");
                return;
            }

            items[count] = item;
            count++;

            Console.WriteLine($"Item {count} added successfully: {item}");

        }

        #endregion

        #region Get

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid index");
                return default!;
            }

            else return
                    items[index];
        }

        #endregion

        #endregion

    }
}