﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);

        }
    }
}
