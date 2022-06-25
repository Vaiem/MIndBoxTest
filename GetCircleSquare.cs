using System;
using System.Collections.Generic;
using System.Text;

namespace MindBox___test
{
    public class GetCircleSquare : BaseSquare<decimal,int>
    { 
        public override decimal OutputSquare(int radius)
        {
            
            return (decimal)(Math.PI * Math.Pow(radius,2));   
        
        }

    }
}
