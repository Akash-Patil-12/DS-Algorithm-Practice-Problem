using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Stack<T> where T :IComparable
    {

        public Node<T> head;
        /// <summary>
        /// Add new data to stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = this.head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted", node.data);
        }
        /// <summary>
        /// Remove top element from stack
        /// </summary>
        public void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} Pop", head.data);
            this.head = this.head.next;
        }
        /// <summary>
        /// show top element
        /// </summary>
        public void Peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Peek element is :" + this.head.data);
            }
        }
        /// <summary>
        /// Check stack is empty or not
        /// </summary>
        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Show all elements of stack
        /// </summary>
        public void ShowStack()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
