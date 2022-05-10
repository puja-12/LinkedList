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
                Console.WriteLine("Select the Program to be Executed :\n1)Add in linklist\n2)Append Method\n3)insert between elements");
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
                        





                }
            }
        }
    }
}


