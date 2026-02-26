using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

public class FruitPriceList
{
    private string[] _names;
    private int[] _prices;
    private int _count;


    public FruitPriceList(int capacity)
    {
        _names = new string[capacity]; 
        _prices = new int[capacity];
        _count = 0;
    }


    public int Count { get; }


    public void Add(string name, int price)
    {
        if (_count >= _names.Length)
        {
            Console.WriteLine("가격표가 가득 찼습니다");
        }

        _names[_count] = name;
        _prices[_count] = price;

        _count++;
    }


    public int this[string name]
    {
        get
        {
            for (int i = 0; i < _count; i++)
            {
                if (name.Equals(_names[i]))
                {
                    return _prices[i];
                }
            }

            return -1;
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >=0 && index < _count)
            {
                return _names[index];
            }

            return string.Empty;
        }
    }
}