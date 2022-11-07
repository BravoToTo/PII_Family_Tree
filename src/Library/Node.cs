using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node: INode
    {
        private Persona person;

        private List<Node> children = new List<Node>();

        public Persona Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int edad)
        {
            Persona person = new Persona(name, edad);
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void accept(IVisitor visitor){
            visitor.Visit(this);
        }
        
    }
}
