﻿using System;

namespace DataStructures_LinkedList
{/// <summary>
/// Program Class
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operations on LinkedList");
            LinkedList list = new LinkedList();
            list.AppendLast(56);
            list.AppendLast(70);
            list.AppendLast(30);
            list.Search(30);
            list.Display();
        }
    }
}