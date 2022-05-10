using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    internal class usingAdd<T>
    {
        internal Node<T> head;
        public void InsertFront(T data)
        {
            Node<T> new_node = new Node<T>(data);
            new_node.next = head;
            head = new_node;
            
        }
        public void display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
