using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{    class Stack
    {
        public int size;
        public int top = -1;
        public int[] arr;
        public Stack(int size)
        {
            this.size = size;
            arr = new int[size];
        }
        
        #region"Stack Array Operations"        
        public int StackArrayisEmpty()
        {
            if (top < 0)
            {
                return 0;
            }

            return 1;
        }
        public void StackArray_Print()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        public void StackArray_Push( int data)
        {
            int i = top;
            arr[i + 1] = data;
            top += 1;
        }
        public void StackArray_Pop()
        {
            int i = top;
            if (i > 0)
            {
                top -= 1;
            }
        }
        public void StackArray_Peek()
        {
            if (top > 0)
            {
                Console.WriteLine("Top is - {0} {1}", top,arr[top]);
            }
            else
            {
                Console.WriteLine("Top is - {0}", 0);
            }
        }

        //stackTop nad stackBottom simply return top(arr[top])  and bottom elements (arr[0])

        //public static void Main(String[] args)
        //{
        //    Stack myStack = new Stack(10);

        //    myStack.StackArray_Push(1);
        //    myStack.StackArray_Push(2);
        //    myStack.StackArray_Push(3);
        //    myStack.StackArray_Push(4);
        //    myStack.StackArray_Push(5);
        //    myStack.StackArrayisEmpty();
        //    myStack.StackArray_Print();
        //    Console.WriteLine("---------------------------");
        //    myStack.StackArray_Pop();
        //    myStack.StackArray_Print();
        //    Console.WriteLine("---------------------------");
        //    myStack.StackArray_Push(8);
        //    myStack.StackArray_Print();
        //    myStack.StackArray_Peek();
        //    Console.ReadKey();
        //}        
        #endregion

        #region"Stack Operation Linked Lists"
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
        }
        public void StackLL_Print()
        {
            Node p = head;
            while (p != null)
            {
                Console.WriteLine(p.data);
                p = p.next;
            }
        }
        public void StackLL_Push(int value)
        {
            Node new_node = new Node();
            new_node.data = value;            
            new_node.next = head;
            head = new_node;
        }
        public void StackLL_pop()
        {
            head = head.next;

        }
        //public static void Main(String[] args)
        //{          

        //    Stack myStack = new Stack();

        //    myStack.StackLL_Push(1);
        //    myStack.StackLL_Push(2);
        //    myStack.StackLL_Push(3);
        //    myStack.StackLL_Push(4);
        //    myStack.StackLL_Print();
        //    Console.WriteLine("--------------------");
        //    myStack.StackLL_pop();
        //    myStack.StackLL_Print();

        //    Console.ReadKey();
        //}

        #endregion
               
    }
}
