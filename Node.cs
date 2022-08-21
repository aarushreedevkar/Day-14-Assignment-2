using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public static class Node
    {
        public int data; //i have define two elements overthere
        public Node next;

       //Constructor
        public Node(int d)
        {
            data = d;
            next = null;

        }
    }
}