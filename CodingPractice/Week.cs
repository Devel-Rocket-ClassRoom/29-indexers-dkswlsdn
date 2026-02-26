using System;
using System.Collections.Generic;
using System.Text;

public class Week
{
    private string[] _weeks;

    public Week()
    {
        _weeks = new string[7];
        Length += 7;
    }

    public Week(int capacity)
    {
        _weeks = new string[capacity];
        Length += capacity;
    }


    public int Length { get; set; }


    public string this[int index]
    {
        get { return _weeks[index]; }
        set { _weeks[index] = value; }
    }
}