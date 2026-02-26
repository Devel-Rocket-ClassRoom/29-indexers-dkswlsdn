using System;
using System.Collections.Generic;
using System.Text;

public class Example
{
    private string[] _items = new string[10];

    public string Name { get; set; }

    public string this[int index]
    {
        get {  return _items[index]; }
        set { _items[index] = value; }
    }
}