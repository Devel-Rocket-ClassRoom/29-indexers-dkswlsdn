using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


public class MultiIndexer
{
    private Hashtable _tables = new Hashtable();

    public string this[int key]
    {
        get { return (string)_tables[key]; }
        set { _tables[key] = value; }
    }

    public string this[string key]
    {
        get { return (string)_tables[key]; }
        set { _tables[key] = value; }
    }
}