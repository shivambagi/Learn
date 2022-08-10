using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class c
    {
    }

    //interface IService
    //{

    //}

    //static class AB
    //{
    //    const int b;
    //    static AB()
    //    {
    //        b = 4;
    //    }

    //}

    //struct D
    //{
    //    static D()
    //    {

    //    }
    //}
    //class Base
    //{
    //    public virtual void Fun()
    //    {
    //        Console.WriteLine("Fun base");
    //    }
    //}


    //class Derived : Base
    //{
    //    public override void Fun()
    //    {
    //        Console.WriteLine("Fun derived");
    //    }
    //}


    //class Child : Derived
    //{
    //    public override void Fun()
    //    {
    //        Console.WriteLine("Fun child");
    //    }
    //}

    //struct str
    //{
    //    public str(int a)
    //    {

    //    }
    //}
}



//string str = "hello world";
//Dictionary<char, int> characterCount = new Dictionary<char, int>();

//foreach (char c in str)
//{
//    if (!characterCount.ContainsKey(c))
//    {
//        characterCount.Add(c, 1);
//    }
//    else
//    {
//        characterCount[c]++;
//    }
//}

//foreach (var character in characterCount)
//{
//    Console.WriteLine("{0} - {1}", character.Key, character.Value);
//}
//Console.ReadKey();




//int i;
//string str = "new word is good";
//StringBuilder reverseSentence = new StringBuilder();

//int Start = 0;
//int End = 0;

//while (End <= str.Length-1)
//{
//    if (str[End] == ' ')
//    {
//        i = End - 1;
//        while (i >= Start)
//        {
//            reverseSentence.Append(str[i]);
//            i--;
//        }
//        reverseSentence.Append(' ');
//        Start = End + 1;
//    }
//    End++;
//}
//int n = reverseSentence.Length;
//for (i = str.Length - 1  ; i >= n; i--)
//{
//    reverseSentence.Append(str[i]);
//}
//Console.WriteLine(reverseSentence.ToString());


//int[] arr = {1,2,3,4,5,6 };
//int[] temp = new int[arr.Length];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (i == arr.Length - 1)
//    {
//        temp[i] = arr[0];
//    }
//    else
//    {
//        temp[i] = arr[i + 1];
//    }
//}

//foreach (int num in temp)
//{
//    Console.Write(num + " ");
//}



//string str = " Welcome to Csharp corner";
//StringBuilder reverseSentence = new StringBuilder();

//int start = 0;
//int end = -1;
//for (int i = 0; i < str.Length; i++)
//{
//    if (str[i] == ' ')
//    {
//        while (end >= start)
//        {
//            reverseSentence.Append(str[end]);
//            end--;
//        }
//        reverseSentence.Append(' ');
//        end = i - 1;
//        start = i + 1;
//    }
//    end++;
//}

//StringBuilder final = new StringBuilder();
//final.Append(reverseSentence);
//for (int i = str.Length - 1; i >= reverseSentence.Length; i--)
//{
//    final.Append(str[i]);
//}

//Console.WriteLine(final);
//Console.ReadKey();