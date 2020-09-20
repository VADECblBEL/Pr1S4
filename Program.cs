using System;

namespace Pr1S4
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 i16 = 1;
            Int32 i32 = 1;
            double db = 1;

            i16 = i32; 
            i16 = db;  
            i32 = i16; //неявное преобр short в int
            i32 = db; 
            db = i32; //неявное преобр int в double
            db = i16; //неявное преобр short в int 
        }
    }
}
