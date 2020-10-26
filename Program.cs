using System;
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
            list.AppendFirst(70);
            list.AppendFirst(30);
            list.AppendFirst(56);
            list.Display();

        }
    }
}