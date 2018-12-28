using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Node
    {
            public Object Element;
            public Node Flink;
            public Node Blink;
            public Node()
            {
                 Element = null;
                 Flink = null;
                 Blink = null;
            }
            public Node(Object theElement)
            {
               Element = theElement;
               Flink = null;
               Blink = null;
            }


    }
    public class LinkedList
    {
        protected Node header;
        public LinkedList()
        {
            header = new Node("header");
        }
        public void Insert(Object newItem, Object after)
        {
            Node current = new Node();
            Node newNode = new Node(newItem);
            current = Find(after);
            newNode.Flink = current.Flink;
            newNode.Blink = current;
            current.Flink = newNode;
        }

        public void Remove(Object n)
        {
           Node p = Find(n);
           if (!(p.Flink == null))
           {
          p.Blink.Flink = p.Flink;
         p.Flink.Blink = p.Blink;
           p.Flink = null;
         p.Blink = null;
           }
        }
        private Node FindLast()
        {
           Node current = new Node();
           current = header;
             while (!(current.Flink == null))
         current = current.Flink;
            return current;
          }
        public void PrintReverse()
        {
        Node current = new Node();
           current = FindLast();
         while (!(current.Blink == null))
            {
          Console.WriteLine(current.Element);
          current = current.Blink;
           }
        }
        private Node Find(Object item)
        {
            Node current = new Node();
            current = header;
            while (current.Element != item)
                current = current.Flink;
            return current;
        }
    }
    class Program
    {
      
     static void Main(string[] args)
        {
           


            //Mylist.Insert("1");
            //Mylist.Insert("2");
            //Mylist.Insert("3");
            //Mylist.Insert("4");
            //Mylist.Insert("5");
      
            Console.ReadLine();
        }
    }
  
}