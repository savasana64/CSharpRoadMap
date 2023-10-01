using System;
using System.Collections;
using System.Collections.Generic;



namespace EnumeratorExample
{
    //Iterator or Cursor or Enumerator
    //description: access items in s set or collection one by one
    //Goal: separate moving through the collection from the collection itself

    //in this example we create an iteraor for number of days in each month


    //first we create a type that we can iterate through: MonthWithDays
    internal class EnumeratorExample
    {
        static void Main(string[] args)
        {
            var collection = new DaysInMonthCollection();

            foreach (var monthWithDays in collection)
            {
                Console.WriteLine($"Days in {monthWithDays.Date}- {monthWithDays.Days}");
            }
        }
    }
}