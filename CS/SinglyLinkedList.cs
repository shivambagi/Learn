using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class SinglyLinkedList
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
        public void print()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + "-->");
                n = n.next;
            }
        }
        
        public void insertFront(int new_data)
        {
            //Step 1 & 2 = Create and Assign data to a new node
            Node front_node = new Node(new_data);

            //Step 3 = Set the next of new node to head
            front_node.next = head;

            //Step 4 = Make the new node as head
            head = front_node;

        }
        public void insertAfterNode(Node prev_node, int new_data)
        {
            //Step 1 = Crete new node
            Node new_node = new Node(new_data);
            // Step 2 = Assign the next of prev node to next of new node
            new_node.next = prev_node.next;
            //Step 3 = Assign new node to next of prev node
            prev_node.next = new_node;
        }
        public void insertLast(int new_data)
        {
            /* 1. Allocate the Node & 
            2. Put in the data 
            3. Set next as null */
            Node new_node = new Node(new_data);

            /* 4. If the Linked List is empty, 
            then make the new node as head */
            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            /* 4. This new node is going to be the last node,  
                so make next of it as null */
            new_node.next = null;

            /* 5. Else traverse till the last node */
            Node last = head;
            while (last.next != null)
                last = last.next;

            /* 6. Change the next of last node */
            last.next = new_node;
            return;
        }

        public void insertAtIndex(int new_data, int index)
        {
            Node new_node = new Node(new_data);
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
        
        public void deleteFirst()
        {
            head = head.next;
        }
        public void deleteAtIndex(int index)
        {
            Node p = head;
            Node q = head.next;
            for (int i = 0; i < index - 1; i++)
            {
                p = p.next;
                q = q.next;
            }
            p.next = q.next;
        }
        public void deleteLast()
        {
            Node p = head;
            Node q = head.next;

            while (q.next == null)
            {
                p = p.next;
                q = q.next;
            }
            p.next = null;
        }
        public void deleteByValue(int value)
        {
            Node p = head;
            Node q = head.next;
            while (q.data != value && q.next != null)
            {
                p = p.next;
                q = q.next;
            }
            if (q.data == value)
            {
                p.next = q.next;
            }


        }

        /* method to create a simple linked list with 3 nodes*/
        public static void Main(String[] args)
        {
            /* Start with the empty list. */
            SinglyLinkedList llist = new SinglyLinkedList();

            llist.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            /* Three nodes have been allocated dynamically.  
            We have references to these three blocks as head,  
            second and third  

            llist.head     second             third  
                |             |                 |  
                |             |                 |  
            +----+------+     +----+------+     +----+------+  
            | 1 | null |     | 2 | null |     | 3 | null |  
            +----+------+     +----+------+     +----+------+ */

            llist.head.next = second; // Link first node with the second node 

            /* Now next of first Node refers to second. So they  
                both are linked.  

            llist.head     second             third  
                |             |                 |  
                |             |                 |  
            +----+------+     +----+------+     +----+------+  
            | 1 | o-------->| 2 | null |     | 3 | null |  
            +----+------+     +----+------+     +----+------+ */

            second.next = third; // Link second node with the third node 

            /* Now next of the second Node refers to third. So all three  
                nodes are linked.  

            llist.head     second             third  
                |             |                 |  
                |             |                 |  
            +----+------+     +----+------+     +----+------+  
            | 1 | o-------->| 2 | o-------->| 3 | null |  
            +----+------+     +----+------+     +----+------+ */
            llist.print();

            //llist.insertFront(4);
            //llist.insertAfterNode(second,4);
            //llist.insertLast(4);
            //llist.insertAtIndex(4,2);
            //Console.WriteLine("\nAfter Insertion");
            //llist.deleteFirst();
            //llist.deleteAtIndex(2);
            //llist.deleteLast();
            llist.deleteByValue(2);
            Console.WriteLine("\nAfter Deletion");
            llist.print();
            Console.ReadKey();
        }

    }
}
