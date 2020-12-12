using System;

namespace WorkingWithInheritance
{

    /*

    Exercise: Design a Stack
    --------------------------
    A Stack is a data structure for storing a list of elements in a LIFO (last in, first out) fashion. 
    Design a class called Stack with three methods. 

    void Push(T obj)
    T Pop()
    void Clear()

    TRENTS OWN NOTES:
    - I've changed this implementation to have generics.
    - This way only one type is allowed in the stack.
    - I've also decided to implement the Linked List myself, instead of using a generic list.

    The full original instructions can be seen in the attached PDF.
    */


    class MyStack<T>
    {
        private class NewNode
        {
            public T _value;
            public NewNode _next;
        }

        private NewNode _root;
        private int _size;

        public void Push(T element)
        {
            if (element == null)
                throw new InvalidOperationException("Element cannot be null.");

            // make copy of current root before pushing
            var oldRoot = _root;

            // clear old root, making it the pushed element.

            _root = new NewNode();
            _root._value = element;
            _root._next = oldRoot;

            // increment size
            _size++;
        }

        public T Pop()
        {
            if (_size == 0)
                throw new InvalidOperationException("Stack is empty!");

            var value = _root._value;

            _root = _root._next;
            _size--;

            return value;
        }

        public void Clear()
        {
            if (_size == 0)
            {
                Console.WriteLine("Stack already empty.");
            }
            else
            {
                while (_root != null)
                {
                    var tempNode = _root._next;
                    _root = null;
                    _root = tempNode;
                }
                Console.WriteLine("Stack cleared.");
            }
        }

        public void Print()
        {
            var tempNode = _root;
            Console.WriteLine("Stack contains");
            while (tempNode != null)
            {
                Console.WriteLine(tempNode._value);
                tempNode = tempNode._next;
            }
        }
    }
}
