using System;
using System.Collections.Generic;

namespace FirstUniqueChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateStart = DateTime.Now;
            Console.WriteLine(getFirstUniqueChar("aabbccdffee"));
            Console.WriteLine((DateTime.Now - dateStart).TotalMilliseconds);
        }

        static int getFirstUniqueChar(string str)
        {
            char[] list = str.ToCharArray();
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < list.Length; i++)
            {
                if (dict.ContainsKey(list[i].ToString()))
                {
                    dict[list[i].ToString()] = -1;
                }
                else
                {
                    dict.Add(list[i].ToString(), i);
                }    
            }

            foreach (var item in dict)
            {
                if (item.Value != -1)
                {
                    return item.Value;
                }
            }
           
            return -1;
        }
        static int getFirstUniqueChar2(string str)
        {
            char[] list = str.ToCharArray();
            
            for (int i = 0; i < list.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i] == list[j])
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                  return i;
            }
            return -1;
        }
    }
}
