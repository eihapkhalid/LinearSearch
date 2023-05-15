using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bl.Interfaces;
using Bl.Services;
using Domains;
using System.Reflection;
namespace LinearSearch.Utlities
{
    public class UiHelper
    {
        #region dependency injection
        IBusinessLayer<TbNumber> oNumberService;
        TbNumber oTbNumber;
        public UiHelper(IBusinessLayer<TbNumber> numberService, TbNumber tbNumber)
        {
            oNumberService = numberService;
            oTbNumber = tbNumber;

        }
        #endregion

        
        public void PerformLinearSearch()
        {
            oTbNumber.numbers = new int[] { 7, 2, 5, 6, 3, 10 };
            oTbNumber.targetNumber = 6;
            int result = oNumberService.LinearSearch(oTbNumber.numbers, oTbNumber.targetNumber);
        }
    }
}
