using System;
using System.Collections.Generic;
using System.Text;

namespace MindBox___test
{
    public class BaseSquare<T,U> 
        where T : struct
        where U : struct
    {
        public virtual T OutputSquare(U num)
        {
            return default(T);
        }
        public virtual T OutputSquare(params U[] num)
        {
            return default(T);
        }
    }
}
