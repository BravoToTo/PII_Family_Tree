using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {            
            Node n1 = new Node("Franco", 23);
            Node n2 = new Node("Ale", 22);
            Node n3 = new Node("Pedro", 20);
            Node n4 = new Node("Nacho", 27);
            Node n5 = new Node("Juan", 29);
            Node n6 = new Node("Santiago", 21);
            Node n7 = new Node("Nico", 30);
            Node n8 = new Node("Diego", 31);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            AgeSumVisitor V1 = new AgeSumVisitor();
            n1.accept(V1);
            System.Console.WriteLine(V1.sum);

            OldestChildrenVisitor V2 = new OldestChildrenVisitor();
            n1.accept(V2);
            System.Console.WriteLine(V2.Oldest);

            LongestNameVisitor V3 = new LongestNameVisitor();
            n1.accept(V3);
            System.Console.WriteLine(V3.Name);
        }
    }
}
