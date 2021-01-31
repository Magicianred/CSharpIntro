using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            sehirler[0] = "İstanbul";

            Console.WriteLine(sehirler.Count);

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }


            MyList<string> myList = new MyList<string>();
            myList.Add("Ankara");
            myList.Add("Ankara");
            myList.Add("Ankara");
            myList.Add("Ankara");
            myList.Add("Ankara");
            myList.Add("Ankara");
            myList[0] = "İstanbul";
            //indexing
            Console.WriteLine(myList.Count);
            //Console.WriteLine(myList[0]);

            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }

        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get
            {
                return _array;
            }
        }

        // indexer
        public T this[int index]
        {
            get
            {
                return _array[index];
            }

            set
            {
                _array[index] = value;
            }
        }
    }
}
