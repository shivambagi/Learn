using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Operations_DS
{
    class InfixPostFix
    {
        public int size;
        public int top = -1;
        public char[] arrSP;

        public InfixPostFix(int size)
        {
            this.size = size;
            arrSP = new char[size];
        }
        public char stackTop(char[] arr)
        {
            if (top < 0)
            {
                return '0';
            }
            return arr[top];
        }
        public void Push(char[] arr, char e)
        {
            top++;
            arr[top] = e;
        }
        public char Pop(char[] arr)
        {
            char ch = arr[top];
            top--;
            return ch;
        }
        public int precedence(char e)
        {
            if (e == '*' || e == '/')
                return 3;
            else if (e == '+' || e == '-')
                return 2;
            else
                return 0;
        }
        public int isOperator(char e)
        {
            if (e == '+' || e == '-' || e == '*' || e == '/')
                return 1;
            else
                return 0;
        }
        public string InfixToPostfix(char[] infixEqn)
        {
            int i = 0;
            string postStr = "";

            while (i < infixEqn.Length)
            {
                if (isOperator(infixEqn[i]) == 0)
                {
                    postStr += infixEqn[i];
                    i++;
                }
                else
                {
                    if (precedence(infixEqn[i]) > precedence(stackTop(arrSP)))
                    {
                        Push(arrSP, infixEqn[i]);
                        i++;
                    }
                    else
                    {
                        postStr += Pop(arrSP);                        
                    }
                }
            }
            while (top > -1)
            {
                postStr += Pop(arrSP);
            }
            return postStr;
        }
        public bool isEmpty(char[] arr)
        {
            if (arr.Length - 1 < 0)
            {
                return true;
            }
            return false;
        }
        public bool isFull(char[] arr)
        {
            if (arr.Length - 1 >= size - 1)
            {
                return true;
            }
            return false;
        }
        //static void Main(String[] args)
        //{
        //    InfixPostFix itp = new InfixPostFix(50);
        //    //string str = "x-y/z-k*d";
        //    //string str = "a+b*c-d";
        //    //string str = "a+b*c-d/e*f";
        //    string str = "a-b/c*d-e--f/h*I++j-/k";
        //    char[] eqn = str.ToCharArray();
        //    Console.WriteLine(str);
        //    Console.WriteLine(itp.InfixToPostfix(eqn));
        //    Console.ReadLine();

        //}
    }
}
