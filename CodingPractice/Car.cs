using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private string[] _cars;


    public Car(int capacity)
    {
        _cars = new string[capacity];

        Length += capacity;
    }


    public int Length { get; set; }


    public string this[int index]
    {
        get { return _cars[index]; }
        set { _cars[index] = value; }
    }
}