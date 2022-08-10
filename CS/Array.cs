using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class Array
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
              
        static void display(int[] array)
        {
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
        }
        static int delete(int[] array,ref int size, int element, int index)
        {
            if (index > size)
            {
                return 0;
            }
            for (int i = index; i < size-1; i++)
            {
                
                array[i] = array[i + 1];
            }
            size = size - 1;
            
            return 1;
        }
        static int insert(int[] array,int size,int element,int index)
        {
            if (index > size)
            {
                return 0;
            }
            for(int i = size-1; i > 0; i--)
            {
                if (element <= array[i]){
                    array[i] = element;
                }
            }
            return 1;
        }
        
        //static void Main(string[] args)
        //{

        //    int[] arr = { 1, 3, 5, 56, 64, 73, 123, 225, 444 };
        //    int size = arr.Length, element = 5, index = 2;

        //    Binary_LinearSearch search = new Binary_LinearSearch();

        //    display(arr);
        //    Console.WriteLine("-------------------------Display");
        //    //insert(arr,size,element,index);
        //    //Console.WriteLine("-------------------------Insert");
        //    //display(arr);
        //    //Console.WriteLine("-------------------------Display");
        //    //delete(arr,ref size, element, index);
        //    //Console.WriteLine("-------------------------Delete");
        //    //display(arr);
        //    //Console.WriteLine("-------------------------display");
        //    Console.WriteLine(search.binarySearch(arr, size, element));
            

        //    Console.ReadKey();
        //}


    }
}
