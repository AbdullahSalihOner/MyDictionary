﻿using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<string> isimler = new MyDictionary<string>();
            isimler.Add("Kadir");
            isimler.Add("Ahmet");
            isimler.List();
        }
    }
}
