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
        public void append(T data)
        {
            /* 1. Allocate the Node &
            2. Put in the data
            3. Set next as null */
            Node<T> new_node = new Node<T>(data);

            /* 4. If the Linked List is empty,
               then make the new node as head */
            if (head == null)
            {
                head = new Node<T>(data);

            }
            else
            {

                /* 4. This new node is going to be
                the last node, so make next of it as null */
                new_node.next = null;

                /* 5. Else traverse till the last node */
                Node<T> last = head;
                while (last.next != null)
                    last = last.next;

                /* 6. Change the next of last node */
                last.next = new_node;
                return;
            }
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
