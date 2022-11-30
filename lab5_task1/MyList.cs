using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(5);
            mylist[0] = 1;
            Console.WriteLine(mylist.Capacity);
            Console.WriteLine(mylist.Count);
            mylist.Add(15);
            Console.WriteLine(mylist.Capacity);
        }
    }

    class MyList<T>
    {
        private T[] myList = null;

        public T this[int index]
        {
            get { return myList[index]; }
            set { myList[index] = value; }
        }

        public MyList()
        {
            this.myList = new T[1];
        }

        public MyList(int count)
        {
            this.myList = new T[count];
        }

        public void Add(T item)
        {
            T[] extendedList = new T[myList.Length + 1];
            extendedList[extendedList.Length - 1] = item;
            myList = extendedList;
        }

        public int Capacity
        {
            get { return myList.Length; }

        }
        public int Count
        {
            get { return myList.Length; }
        }
    }

}