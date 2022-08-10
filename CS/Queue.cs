using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class Queue
    {
        public class QueueObj
        {
            public int size;
            public int f = -1;
            public int r = -1;
            public int[] arr;

            public QueueObj(int size)
            {
                this.size = size;
                arr = new int[size];
            }
        }
        
        public bool isEmpty(QueueObj obj)
        {
            if(obj.f == obj.r)
            {
                return true;
            }
            return false;
        }
        public bool isFull(QueueObj obj)
        {
            if (obj.r == obj.size - 1)
            {
                return true;
            }
            return false;
        }
        public int enQueue(QueueObj obj,int value)
        {
            if (isFull(obj))
            {
                return 0;
            }
            obj.r += 1;
            obj.arr[obj.r] = value;
            return 1;
        }
        public int deQueue(QueueObj obj)
        {
            if (isEmpty(obj))
            {
                return 0;
            }
            obj.f += 1;
            int i = obj.arr[obj.f];
            return i;
        }

        public void printQueue(QueueObj obj)
        {            
            for (int i = obj.f + 1; i <= obj.r; i++)
            {
                Console.WriteLine(obj.arr[i] + " ");
            }
        }
        //static void Main(String[] args)
        //{
        //    QueueObj qObj = new QueueObj(8);
        //    Queue Q = new Queue();
        //    Q.enQueue(qObj, 1);
        //    Q.enQueue(qObj, 2);
        //    Q.enQueue(qObj, 3);
        //    Q.enQueue(qObj, 4);
        //    Q.enQueue(qObj, 5);
        //    Q.printQueue(qObj);
        //    Console.WriteLine("--------------------");
        //    Console.WriteLine(Q.deQueue(qObj));
        //    Console.WriteLine(Q.deQueue(qObj));
        //    Console.WriteLine(Q.deQueue(qObj));
        //    Console.WriteLine("--------------------");
        //    Q.printQueue(qObj);
        //    Q.enQueue(qObj, 6);
        //    Q.enQueue(qObj, 7);
        //    Console.WriteLine("--------------------");
        //    Q.printQueue(qObj);

        //    Console.ReadKey();
        //}
    }
}
