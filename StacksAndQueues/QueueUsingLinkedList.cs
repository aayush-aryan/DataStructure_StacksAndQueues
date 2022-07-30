using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    class QueueUsingLinkedList
    {
        Node head = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue ", node.data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal Node Dequeue()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;

        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
