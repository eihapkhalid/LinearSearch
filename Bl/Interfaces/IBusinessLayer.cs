using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Interfaces
{
    public interface IBusinessLayer<T>
    {
        int LinearSearch(int[] arr, int target);
    }
}
