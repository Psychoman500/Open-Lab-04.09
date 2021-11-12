using System;
using System.Collections;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            ArrayList array = new ArrayList();
            foreach(string i in strings)
            {
                if (!array.Contains(i))
                {
                    array.Add(i);
                }
            }
            strings = array.ToArray(typeof(string)) as string[];
            return strings;

        }
    }
}
