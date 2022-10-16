using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NodeList node = new NodeList();
            node.AddLast(1235);
            node.AddLast(1235);
            node.AddLast(1235);
            node.AddLast(1235);
            node.AddLast(1235);
            node.AddLast(1235);
            node.AddLast(1235);
            node.Add(31,3);
            node.PrintList();
        }
    }
}
