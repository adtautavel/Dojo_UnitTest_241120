using System;

namespace NUnitTest_Dojo241120
{
    public class Codewar
    {
        public Codewar()
        {
        }
        // charrarray = ['a','b','c','d','e','f']
        public string[] SplitString(string entry)
        {
      
            
            string[] result = new string[Math.Abs(entry.Length / 2)];

            if (entry.Length % 2 == 0) //It is odd
            {
                int j = 0;
                

                for (int i=0; i <= entry.Length/2 ; i = i+2)
                {
                    result[j] = String.Concat(entry[i], entry[i+1]);
                    j++;
                }             
            }

            else
             {

                 int j = 0;
                 result = new string[(entry.Length+1) / 2];
                 for (int i=0; i < (entry.Length-1)/2 ; i=i+2) // It is even
                 {
                     result[j] = (entry[i] + entry[i + 1]).ToString();
                     j++;
                 }
                 result[j+1] = (entry[entry.Length] + "_").ToString();
             }
            
            return result;
         }
    }
}