using System;

namespace Lesson2Task1_Implicit_and_explicit_type_casting_
{
    class Program
    {
        static void Main()
        {
            #region Variable initialization
            int intVariable = 1;
            uint uIntVariable = 2u;
            double doubleVariable = 2.4d;
            float floatVariable = 3.3f;
            byte byteVariable = 1;
            decimal decimalVariable = 4.7m;
            #endregion

            double variable1 = intVariable;//Implicit type casting from System.Int32 -> System.Double
            float variable2 = byteVariable;//Implicit type casting from System.Byte -> System.Single 
            double variable3 = floatVariable;//Implicit type casting from System.Single -> System.Double 
            decimal variable4 = (decimal)doubleVariable;//Explicit type casting from System.Double -> System.Decimal
            ushort variable5 = (ushort)uIntVariable;//Explicit type casting from System.UInt32 -> System.UInt16
            float variable6 = (float)decimalVariable;//Explicit type casting from System.Decimal -> System.Single

        }
    }
}
