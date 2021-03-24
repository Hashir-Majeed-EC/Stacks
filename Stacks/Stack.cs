using System;
using System.Collections.Generic;
using System.Text;

namespace Stacks
{
    class Stack<T>
    {
        private T[] objects;
        private int top;
        private int depth;
        public Stack(int depth)
        {
            objects = new T[depth];
            top = 0;
            this.depth = depth;
        }

        public void Push(T s)
        {

            if (top == depth)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                objects[top] = s;
                top++;
            }

            
        }

        public T Pop()
        {
            
            if (top == 0)
            {
                Console.WriteLine("Invalid");
                return null;
            }
            else
            {
                top--;
                return objects[top];
            }

        }

    }
}
