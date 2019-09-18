using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz2
{
    class ArrayList
    {
        private object[] _list;

        public ArrayList()
        {
            _list = new object[0];
        }
        public virtual void Add(object value)
        {
            //create a new array of Length + 1
            object[] newList = new object[_list.Length + 1];
            //put the values of the old array into the new array
            for (int i = 0; i < _list.Length; i++)
            {
                newList[i] = _list[i];
            }
            //put the new value at the end new array 
            newList[newList.Length - 1] = value;
            //set the current array to the new array 
            _list = newList;
        }

        public virtual void Remove(int index)
        {
            //create a new array of Length + 1
            object[] newList = new object[_list.Length - 1];
            //put the values of the old array into the new array 
            int newPosition = 0;
            for (int i = 0; i < _list.Length; i++)
            {
                if (i != index)
                {
                    newList[newPosition] = _list[i];
                    newPosition++;
                }
            }
            //set the current array to the new array 
            _list = newList;
        }
        public virtual void Clear()
        {
            //set the current array to a new empty array 
            _list = new object[0];
        }

        public virtual object this[int index]
        {
            set
            {
                _list[index] = value;
            }
            get
            {
                return _list[index];
            }


        }
        public int Length
        {
            get
            {
                return _list.Length;
            }
        }
    }
}
