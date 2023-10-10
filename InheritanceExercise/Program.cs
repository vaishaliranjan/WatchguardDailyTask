using System;
using System.Collections;
using System.Reflection;

namespace CSharpInter
{
    public class Stack
    {
        private ArrayList list;
        private int ptr;

        public Stack()
        {
            list = new ArrayList();
            ptr = -1;
        }

        public void Push(Object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException();
            }
            list.Add(obj);
            ptr++;
        }
        public object Pop()
        {
            if(ptr <0)
            {
                Console.WriteLine("List is empty!!");
                return null;
            }
            Object obj1 = list[ptr];
            list.RemoveAt(ptr);
            ptr--;
            return obj1;
        }
        public void Clear()
        {
            list.Clear();
        }
    }
    class Oct10
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push(null);
        }
    }
}