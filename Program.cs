﻿//premitive data bytes in cSharp

///*****************************WHOLE NUMBERS*************************************************
//sbyte   -128 to 127	Signed 8-bit integer	System.SByte
//byte	0 to 255	Unsigned 8-bit integer	System.Byte
//short	-32,768 to 32,767	Signed 16-bit integer	System.Int16
//ushort	0 to 65,535	Unsigned 16-bit integer	System.UInt16
//int	-2,147,483,648 to 2,147,483,647	Signed 32-bit integer	System.Int32
//uint	0 to 4,294,967,295	Unsigned 32-bit integer	System.UInt32
//long	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	Signed 64-bit integer	System.Int64
//ulong	0 to 18,446,744,073,709,551,615	Unsigned 64-bit integer	System.UInt64
//nint	Depends on platform (computed at runtime)	Signed 32-bit or 64-bit integer	System.IntPtr
//nuint	Depends on platform (computed at runtime)	Unsigned 32-bit or 64-bit integer

//*********************************************************************************

//float   ±1.5 x 10−45 to ±3.4 x 1038	~6-9 digits	4 bytes	System.Single --> 7 digit precision
//double	±5.0 × 10−324 to ±1.7 × 10308	~15-17 digits	8 bytes	System.Double --> 15 digit precision
//decimal	±1.0 x 10-28 to ±7.9228 x 1028	28-29 digits	16 bytes	System.Decimal --> 28 digit precision

//*********************************************************************************

//decimal is preciser tha double

namespace PremitiveDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1; //declaration

            num1 = 42; //initialization
            int num2 = 13;

            Console.WriteLine(num1); //displays the value

            Console.WriteLine("num1: " + num1); //using concatenation

            double dDiv = num1 / num2;
            Console.WriteLine("dDiv: " + dDiv); //does not print after comma

            double dDiv2 = (double)num1 / num2;
            Console.WriteLine("dDiv: " + dDiv2); //prints after comma


        }
    }
}