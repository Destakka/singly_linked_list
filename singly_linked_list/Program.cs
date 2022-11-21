using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace singly_linked_list

{
    //each node consist of the information part and like to the next node
    class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }
    class list
    {
        node START;
        public list()
        {
            START = null;
        }
        public void addNote()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student : ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            //if the node to be inserted is the first node 
            if (START == null || nim <= START.rollNumber) ;
            {
                if ((START != null) && (nim == START.rollNumber)) ;
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
        }
    }
}