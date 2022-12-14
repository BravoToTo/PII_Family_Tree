using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Franco", 23);
            Persona p2 = new Persona("Ale", 22);
            Persona p3 = new Persona("Pedro", 20);
            Persona p4 = new Persona("Nacho", 27);
            Persona p5 = new Persona("Juan", 29);
            Persona p6 = new Persona("Santiago", 21);
            Persona p7 = new Persona("Nico", 30);
            Persona p8 = new Persona("Diego", 31);

            Node<Persona> n1 = new Node<Persona>(p1);
            Node<Persona> n2 = new Node<Persona>(p2);
            Node<Persona> n3 = new Node<Persona>(p3);
            Node<Persona> n4 = new Node<Persona>(p4);
            Node<Persona> n5 = new Node<Persona>(p5);
            Node<Persona> n6 = new Node<Persona>(p6);
            Node<Persona> n7 = new Node<Persona>(p7);
            Node<Persona> n8 = new Node<Persona>(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // Creo los visitors y visito el árbol.
            AgeSumVisitor V1 = new AgeSumVisitor();
            System.Console.WriteLine(V1.getAgeSum(n1));

            OldestChildrenVisitor V2 = new OldestChildrenVisitor();
            System.Console.WriteLine(V2.getOldest(n1));

            LongestNameVisitor V3 = new LongestNameVisitor();
            System.Console.WriteLine(V3.getLongestName(n1));
        }
    }
}
