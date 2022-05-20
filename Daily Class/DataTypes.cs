using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    internal class DataTypes
    {
        static void Main(string[] args)
        {
            /* Two Types of datatypes 
             1. Signed 2. Unsigned
             
            1. Signed = Positive and Negative numbers Both are allowed.
               E.g. short,int,long,sbyte.
            2. Unsigned = Only Positive numbers are allowed.
               E.g. byte,ushort,uint,ulong.

               ushort = unsigned short

               byte b = -9; it throws error byte range is 0 to 255 that's why its not accept -ve.
               But By using sbyte it accepted bcoz sbyte range is -128 to 127
               sbyte b = -90;

               If we want int,short,long always take positive then we use uint,ulong,ushort.
               range of uint is 0 to 4,294,967,295.
               that's why only accept +ve not -ve.
               uint i = 67;
            
            In case of string u write first letter is small or captial it's work like a string.
                string s = "name";
                String sn = "Name";
            Both cases are satisfied boz String is alias of string.

            u can also write like
                int32 n = 56;

            ------------------------------------------------------------------------------------

            Accept Data

            Two type of Type casting 
            1. Implicit 2. Expicit

            1. Implicit = 
               In implicit datatype automatically converted.

               byte-> short-> int-> long-> float-> double-> decimal.
                       \      /
                         char

               E.g. int n = 89;
                    long k = n; -- it accepted.

               But in case,
                    int n = 10;
                    short s = n; -- it not accepted bcoz int size is 4 byte & short is 2 byte
               that's why big value not converted into small value it can't handle.
               Size matter.

            2. Explicit = 
               In explicit we need manually converted datatypes.when we need to accept data 
               forcefully so it can allowed by using front of starting value.

                E.g. int n = 34;
                     short s = (short) n;
                                  |
                             Type Casting 
            */
        }
    }
}
