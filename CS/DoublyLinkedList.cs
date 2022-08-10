using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class DoublyLinkedList
    {
        Node head; // head of list         
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int d)
            {
                data = d;
                next = null;
            } // Constructor 
        }

       
        public void printDL()
        {
            Node p = head;
            Node last = null;
            while (p != null)
            {
                Console.WriteLine(p.data + " ");
                last = p;
                if (last.prev == p.next)
                {
                    p = null;
                }
                else
                {
                    p = p.next;
                }
            }

            while (last != null)
            {
                Console.WriteLine(last.data + " ");
                last = last.prev;
            }
        }
        public void insertDLFront(int data)
        {
            Node new_node = new Node(data);
            Node p = head;
            head.prev = new_node;
            new_node.next = head;
            new_node.prev = null;
            head = new_node;
        }
        public void insertDLEnd(int data)
        {
            Node new_node = new Node(data);
            Node p = head;
            Node last = null;
            while (p != null)
            {
                last = p;
                if (last.prev == p.next)
                {
                    p = null;
                }
                else
                {
                    p = p.next;
                }
            }
            last.next = new_node;
            new_node.prev = last;
        }

        //public static void Main(String[] args)
        //{
        //    DoublyLinkedList llist = new DoublyLinkedList();

        //    llist.head = new Node(1);
        //    Node second = new Node(2);
        //    Node third = new Node(3);
        //    Node fourth = new Node(4);

        //    llist.head.prev = null;
        //    llist.head.next = second;
        //    second.prev = llist.head;
        //    second.next = third;

        //    third.prev = second;
        //    third.next = fourth;

        //    fourth.prev = third;
        //    fourth.next = third;

        //    llist.printDL();
        //    Console.WriteLine("--------------------------");
        //    //llist.insertDLFront(5);
        //    llist.insertDLEnd(5);
        //    llist.printDL();
        //    Console.ReadKey();


        //}

    }
}
