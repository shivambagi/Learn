using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class CircularLinkedList
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
        
        public void printCircular()
        {
            Node p = head;
            do
            {
                Console.WriteLine(p.data + " ");
                p = p.next;
            } while (p != head);
        }

        public Node insertCircularFront(int data)
        {
            Node new_node = new Node(data);
            Node p = head;
            while (p.next != head)
            {
                p = p.next;
            }
            p.next = new_node;
            new_node.next = head;
            head = new_node;

            return head;
        }
        public void insertCircularEnd(int data)
        {
            Node new_node = new Node(data);
            Node p = head;
            while (p.next != head)
            {
                p = p.next;
            }
            p.next = new_node;
            new_node.next = head;
        }

        public void insertCircularAtIndex(int data, int index)
        {
            Node new_node = new Node(data);
            Node p = head;
            int i = 0;

            while (i != index - 1)
            {
                p = p.next;
                i++;
            }
            new_node.next = p.next;
            p.next = new_node;

        }
        //public static void Main(String[] args)
        //{
        //    CircularLinkedList llist = new CircularLinkedList();

        //    llist.head = new Node(1);
        //    Node second = new Node(2);
        //    Node third = new Node(3);
        //    Node fourth = new Node(4);

        //    llist.head.next = second;
        //    second.next = third;
        //    third.next = fourth;
        //    fourth.next = llist.head;

        //    llist.printCircular();
        //    //llist.head = llist.insertCircularFront(5);
        //    //llist.insertCircularEnd(5);
        //    llist.insertCircularAtIndex(5, 2);
        //    Console.WriteLine("---------------");
        //    llist.printCircular();
        //    Console.ReadKey();
        //}


    }
}
