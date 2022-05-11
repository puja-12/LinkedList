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
            while (true)
            {
                Console.WriteLine("Select the Program to be Executed :\n1)Add in linklist\n2)Append Method\n3)insert between elements\n4)deletion from front\n5)delete from end\n6)find position of Node\n7)add 40 after 30\n8)delettion between nodes\n9)sortedLinklist");
                int Option = Convert.ToInt32(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        usingAdd<int> Add = new();
                        Add.InsertFront(70);
                        Add.InsertFront(30);
                        Add.InsertFront(56);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        Add.display();
                        Console.WriteLine("\n");
                        break;
                    case 2:

                        usingAdd<int> appendmethod = new();
                        appendmethod.InsertFront(56);
                        appendmethod.append(30);
                        appendmethod.append(70);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        appendmethod.display();
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        usingAdd<int> insert = new();
                        insert.InsertFront(56);
                        insert.append(70);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        insert.display();
                        Console.WriteLine("\n");
                        Console.WriteLine("Inserting the Element '30' in between 56 and 70");
                        insert.insertAfter(insert.head, 30);
                        Console.WriteLine("The final elements in LinkedList are:");
                        insert.display();
                        Console.WriteLine("\n");
                        break;
                    case 4:
                        usingAdd<int> remove = new();
                        remove.InsertFront(70);
                        remove.InsertFront(30);
                        remove.InsertFront(56);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        remove.display();
                        Console.WriteLine("remove the first element");
                        remove.pop_front();
                        Console.WriteLine("The final elements in LinkedList are:");
                        remove.display();
                        Console.WriteLine("\n");
                        break;
                    case 5:
                        usingAdd<int> remove2 = new();
                        remove2.InsertFront(56);
                        remove2.InsertFront(70);
                        remove2.InsertFront(30);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        remove2.display();
                        Console.WriteLine("remove the last element");
                        remove2.pop_back(56);
                        Console.WriteLine("The final elements in LinkedList are:");
                        remove2.display();
                        Console.WriteLine("\n");
                        break;
                    case 6:
                        usingAdd<int> found = new();
                        found.InsertFront(56);
                        found.InsertFront(70);
                        found.InsertFront(30);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        found.display();
                        Console.WriteLine("find position of 30");
                        found.SearchElement(30);
                        found.display();
                        break;
                    case 7:
                        usingAdd<int> insert2 = new();
                        insert2.InsertFront(70);
                        insert2.InsertFront(30);
                        insert2.InsertFront(56);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        insert2.display();
                        Console.WriteLine("Inserting the Element '40' after 30");
                        insert2.insertAfter(insert2.head.next, 40);
                        Console.WriteLine("The final elements in LinkedList are:");
                        insert2.display();
                        break;
                    case 8:
                        usingAdd<int> remove3 = new();
                        remove3.InsertFront(70);
                        remove3.InsertFront(40);
                        remove3.InsertFront(30);
                        remove3.InsertFront(56);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        remove3.display();
                        Console.WriteLine("find position of 40");
                        remove3.SearchElement(40);
                        Console.WriteLine("remove the 40");
                        remove3.popAt(40);
                        Console.WriteLine("The Elements of the Linkedlist are : ");
                        remove3.display();
                        Console.WriteLine("No. of nodes: " + remove3.countNodes());
                        break;
                    case 9:
                        usingAdd<int> Sorting = new();
                        Sorting.sortedInsert(56);
                        Sorting.sortedInsert(30);
                        Sorting.sortedInsert(40);
                        Sorting.sortedInsert(70);
                        Console.Write("The Sorted elements in LinkedList are: ");
                        Sorting.display();
                        Console.WriteLine("\n");
                        break;

                }

            }
        }
    }

}


