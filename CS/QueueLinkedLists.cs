using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class QueueLinkedLists
    {
        Node f = null;// head of list         
        Node r = null;
        // f (  head-->p-->p-->p-->null    ) r
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            } // Constructor 
        }
        public void print()
        {
            Node n = f;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void enQueue(int new_data)
        {
            Node n = new Node(new_data);
            if(r == null)
            {
                f = n;
                r = n;
            }
            else
            {
                r.next = n;
                r.data = n.data;
            }
            
            Console.WriteLine(r.data);
        }

        public void deQueue()
        {            
            if (f == null)
            {
                return;
            }

            Node n = f;
            f = f.next;

            if(f == null)
            {
                r = null;
            }
            Console.WriteLine(f.data);
        }
        //public static void Main(String[] args)
        //{
        //    QueueLinkedLists q = new QueueLinkedLists();
        //    q.enQueue(1);
        //    q.enQueue(2);
        //    q.enQueue(3);
        //    q.enQueue(4);
        //    q.enQueue(5);
        //    Console.WriteLine("----------------------------");
        //    q.print();
        //    Console.WriteLine("----------------------------");
        //    q.deQueue();
        //    q.deQueue();
        //    q.deQueue();
        //    Console.WriteLine("----------------------------");
        //    q.print();
        //    Console.ReadKey();
        //}
    }
}
