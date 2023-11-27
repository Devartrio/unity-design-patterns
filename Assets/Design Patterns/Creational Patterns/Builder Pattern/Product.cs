using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Builder
{
    public class Product
    {
        private List<object> parts = new List<object>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < parts.Count; i++)
            {
                str += parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2);

            return "Product parts: " + str + "\n";
        }
    }
}
