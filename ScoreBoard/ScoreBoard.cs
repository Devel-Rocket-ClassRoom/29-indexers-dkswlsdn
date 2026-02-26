using System;
using System.Collections.Generic;
using System.Text;

public class ScoreBoard
{
    private string[] _names;
    private int[] _scores;
    private int _count;


    public ScoreBoard(int capacity)
    {
        _names = new string[capacity]; 
        _scores = new int[capacity];
        _count = 0;
    }


    public int Count { get { return _count; } }


    public void Register(string name, int score)
    {
        if (Count >= _names.Length)
        {
            return;
        }

        _names[_count] = name;
        _scores[_count] = score;

        _count++;
    }


    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < _names.Length)
            {
                return _names[index];
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public int this[string name]
    {
        get
        {
            for (int i = 0; i < Count; i++)
            {
                if (_names[i].Equals(name))
                {
                    return _scores[i]; 
                }
            }

            return -1;
        }

        set
        {
            for (int i = 0; i < Count; i++)
            {
                if (_names[i].Equals(name))
                {
                    _scores[i] = value;
                }
            }
        }
    }
}