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
            usingAdd<int> add = new();
            add.InsertFront(70);
            add.InsertFront(30);
            add.InsertFront(56);

            Console.WriteLine("The Elements of the Linkedlist are : ");
           add.display();
            Console.WriteLine("\n"); 
        }
        }
    }

