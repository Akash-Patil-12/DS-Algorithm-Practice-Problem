using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class Queue<T> where T :IComparable
    {
        Node<T> head;
        /// <summary>
        /// Remove last element 
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T number=default(T);
            if (this.head == null)
            {
                return default(T);
            }
            else
            {
                while (this.head != null)
                {
                    number = this.head.data;
                    this.head = this.head.next;
                    return number;
                }
            }
            return number;
        }
        /// <summary>
        /// Insert new element
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into queue", node.data);
            }
        }
        /// <summary>
        /// Show list of all Queue element
        /// </summary>
        public void Show()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Check queue is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            Node<T> temp = this.head;
            if (temp == null)
                return true;
            return false;
        }
        /// <summary>
        /// return size of queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            Node<T> temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
