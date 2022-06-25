using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MindBox___test
{
   public class GetTriangleSquare : BaseSquare<decimal,int>
    {
        public override decimal OutputSquare(params int[] num)
        {
            decimal S;
            var NumSort = num.OrderBy(o => o).ToArray();

            if (Math.Pow(NumSort[2],2) == Math.Pow(NumSort[0],2) + Math.Pow(NumSort[1],2))
            {
                S = (NumSort[0] * NumSort[1]) / 2;
                return S;
            }
       
            int p = num.Sum()/2;
            S = (decimal)Math.Sqrt(p * (p - num[0]) * (p - num[1]) * (p - num[2]));
            return S;
        }
    }
}
