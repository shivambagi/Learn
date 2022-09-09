
string str = "abcd";

for (int i = 0; i < str.Length; ++i)  
     {  
         StringBuilder subString = new StringBuilder(str.Length - i);  
         for (int j = i; j < str.Length; ++j)  
         {  
             subString.Append(str[j]);  
             Console.Write(subString + " ");  
         }  
     }  
