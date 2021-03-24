using System;
using System.Collections;
using System.Collections.Generic;
namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(3);
            stack.Push(new Student("Sam", "F----"));
            stack.Push(new Student("Vanya", "F----"));
            stack.Push(new Student("Hashir", "A*"));
            stack.Pop().Display();
            stack.Pop().Display();
            stack.Pop().Display();

        }
    }
}
    