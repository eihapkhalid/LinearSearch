using Bl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Services
{
    public class NumberService : IBusinessLayer
    {
        public int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // Match found, returning the index of the element.
                }
            }
            return -1; // No match found, returning -1.
        }
    }
}
