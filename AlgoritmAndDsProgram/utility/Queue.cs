using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDSPrograms.Utility
{
    public class Queue<T> where T : IComparable
    {
        Node<T> front;
        Node<T> rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        internal void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            // If queue is empty, then new node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", data);
        }
        internal bool IsEmpty()
        {
            Node<T> temp = this.front;
            if (temp == null)
            {
                return true;
            }
            while (temp != null)
            {
                temp = temp.next;
            }
            return false;
        }
        internal T Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node<T> temp = this.front;
            this.front = this.front.next;
            // If front becomes null, then change rear also as null  
            if (this.front == null)
            {
                this.rear = null;
            }
            return temp.data;
        }
        public void Display()
        {
            Node<T> temp = this.rear;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}