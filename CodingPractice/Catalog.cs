using System;
using System.Collections.Generic;
using System.Text;

public class Catalog
{
    public string this[int index]
    {
        get => index % 2 == 0 ? $"{index}: 짝수 반환" : $"{index}: 홀수 반환";
    }
}