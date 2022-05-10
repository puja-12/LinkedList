// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class program
    {
            public static void Main(String[] args)
            {
                /* Start with the empty list. */
                LinkedList llist = new LinkedList();

                llist.head = new Node(70);
                Node second = new Node(30);
                Node third = new Node(56);



                llist.head.next = second; // Link first node with the second node


                second.next = third; // Link second node with the third node
                 Console.WriteLine("inserted elements");
                  llist.display();
        }
        }
    }

