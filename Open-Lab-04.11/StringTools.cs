using System;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] olivero = str.ToCharArray();
            Array.Sort(olivero);
            return new string (olivero);
        }
    }
}
    
