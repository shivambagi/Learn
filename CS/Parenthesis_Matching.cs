using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class Parenthesis_Matching
    {
        public int size;
        public int top = -1;
        public char[] arr;

        public Parenthesis_Matching(int size)
        {
            this.size = size;
            arr = new char[size];
        }
        public bool isEmpty()
        {
            if (top < 0)
            {
                return true;
            }
            return false;
        }
        public bool isFull()
        {
            if (top >= size - 1)
            {                
                return true;
            }
            return false;
        }
        public void Push(char value)
        {
            if (isFull())
            {
                Console.WriteLine("Stack is Full(Overflow)");
            }
            else
            {
                top += 1;
                arr[top] = value;
            }
        }
        public char Pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty(Underflow)");
                return '0';
            }
            else
            {
                
                char val = arr[top];
                top = top - 1;
                return val;
            }
        }        
        public bool match(char a,char b)
        {
            if (a == '{' && b == '}')
            {
                return true;
            }
            if (a == '[' && b == ']')
            {
                return true;
            }
            if (a == '(' && b == ')')
            {
                return true;
            }
            return false;
        }
        public int parenthesisMatching(char[] exp)
        {
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                {
                    Push(exp[i]);
                }
                else if(exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
                {
                    if (isEmpty())
                    {
                        return 0;
                    }
                    char popped = Pop();
                    if (!match(popped,exp[i]))
                    {
                        return 0;
                    }
                }
            }

            if (isEmpty())
            {
                return 1;
            }else
            {
                return 0;
            }

        }
        //static void Main(String[] args)
        //{
        //    //char[] exp = { '{', '(', ')', '}', '[', ']'};
        //    //char[] exp = { ')', '(' };

        //    //string str = "{(a+b)}[(x*y)]";
        //    //char[] exp = s.ToCharArray();

            

        //    string str = "{(a+b)}[(x*y)]";
        //    char[] exp = new char[str.Length];
        //    for (int i = 0; i < str.Length; i++)
        //    {
        //        exp[i] = str[i];
        //    }

        //    //string s = string.Join("", charArr); // Convert char array to string
        //    //string s = new string(charArr); // Convert char array to string

        //    Parenthesis_Matching mystack = new Parenthesis_Matching(100);
        //    if (mystack.parenthesisMatching(exp) == 1)
        //    {
        //        Console.WriteLine("Expression Balanced");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Expression UnBalanced");
        //    }

        //    Console.ReadKey();
        //}
    }
}
