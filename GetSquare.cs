using System;
using System.Collections.Generic;
using System.Text;

namespace MindBox___test
{
    public class  GetSquare    
    {
        public static T GetS<T,U>(BaseSquare<T,U> squareFigur,U input)
        where T : struct
        where U : struct
        {

            return squareFigur.OutputSquare(input);
        }


        public static T GetS<T, U>(BaseSquare<T, U> squareFigur, params U[] input)
        where T : struct
        where U : struct
        {

            return squareFigur.OutputSquare(input);
        }
    }
}
