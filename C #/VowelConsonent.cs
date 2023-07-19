using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_basics
{
    internal class VowelConsonent
    {
        static void Main(string[] args)
        {
            String s1 = "mahendra";

            char[] arr = s1.ToCharArray();
            int vovel = 0;
            int consonent = 0;
            for(int i=0; i<arr.Length; i++) 
            {
                if (arr[i] == 'a' || arr[i]=='e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    vovel += 1;
                }
                else
                {
                    consonent += 1;
                }
            }
            Console.WriteLine("Totel Vovels : " + vovel);
            Console.WriteLine("TOtel Consonent : " + consonent);
        }
    }
}
