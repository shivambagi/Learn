using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class Circular_Queue
    {
        //public struct CircQueueObj
        //{
        //    public int size;
        //    public int f;
        //    public int r;
        //    public int[] arr;
        //}

        public class CircQueueObj
        {
            public int size;
            public int f = -1;
            public int r = -1;
            public int[] arr;

            public CircQueueObj(int size)
            {
                this.size = size;
                arr = new int[size];
            }
        }

        public bool isEmpty(CircQueueObj obj)
        {
            if (obj.f == obj.r)
            {
                return true;
            }
            return false;
        }
        public bool isFull(CircQueueObj obj)
        {            
            if ((obj.r + 1) % obj.size == obj.f)
            {
                return true;
            }
            return false;
        }
        public int enQueue(CircQueueObj obj, int value)
        {
            if (isFull(obj))
            {
                return 0;
            }
            obj.r = (obj.r + 1) % obj.size;
            obj.arr[obj.r] = value;
            return 1;
        }
        public int deQueue(CircQueueObj obj)
        {
            if (isEmpty(obj))
            {
                return 0;
            }
            obj.f = (obj.f + 1) % obj.size;
            int i = obj.arr[obj.f];
            obj.arr[obj.f] = 0;
            return i;
        }
        public void printQueue(CircQueueObj obj)
        {            
                for (int i = 0; i <= obj.size - 1; i++)
                {
                    Console.WriteLine(obj.arr[i] + " ");
                }
        }
        //static void Main(String[] args)
        //{
        //    CircQueueObj qObj = new CircQueueObj(5);
        //    Circular_Queue Q = new Circular_Queue();
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
