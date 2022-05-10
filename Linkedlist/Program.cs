// See https://aka.ms/new-console-template for more information
using System;
namespace Linkedlist
{
    class program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("welcome to linkedlist programming");
            CreatingLinkedlist linkedlist = new CreatingLinkedlist();
            linkedlist.head = new Node(70);
            Node second = new Node(30);
            Node third = new Node(56);
            linkedlist.head.next = second;
            second.next = third;
            Console.WriteLine("inserted elements");
            linkedlist.display();
        }
    }
}
