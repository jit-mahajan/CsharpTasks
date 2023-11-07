using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCreation
{
    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("you cannot add Null object i Stack");

            _list.Add(obj);
        }


        public object Pop()
        {

            if (_list.Count == 0)
                throw new InvalidOperationException("Stack is Empty");

            var index = _list.Count - 1;
            var toReturn =  _list[index];
            _list.RemoveAt(index);

            return toReturn;
        }
    }
}
