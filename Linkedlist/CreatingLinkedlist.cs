using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    public class CreatingLinkedlist
    {
       internal Node head;

        public void InsertFront(int data)
        {
            Node new_node = new Node(data);
            new_node.next = head;
            head = new_node;
        }
        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
