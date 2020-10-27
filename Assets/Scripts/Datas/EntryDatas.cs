using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct CustomDate
{
    public int Year, Month, Day;
    public CustomDate(int year, int month, int day)
    {
        this.Year = year;
        this.Month = month;
        this.Day = day;
    }

    static public CustomDate FromDateTime(DateTime date)
    {
        return new CustomDate(date.Year, date.Month, date.Day);
    }
}


[Serializable]
public class IBData
{
    public CustomDate myDate;
    public int myIndex;
    public string belief;
    public string debate;
    public IBData(CustomDate myDate, int myIndex, string belief, string debate)
    {
        this.myDate = myDate;
        this.myIndex = myIndex;
        this.belief = belief;
        this.debate = debate;
    }
    public IBData(CustomDate myDate, int myIndex)
    {
        this.myDate = myDate;
        this.myIndex = myIndex;
        this.belief = "";
        this.debate = "";
    }


    // Getters
    public bool IsEmpty() { return String.IsNullOrWhiteSpace(belief) && String.IsNullOrWhiteSpace(debate); }
}
