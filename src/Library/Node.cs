using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>: INode<T>
    {
        private T content;

        private List<Node<T>> children = new List<Node<T>>();

        public T Content {
            get
            {
                return this.content;
            }
        }

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            this.content = t;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void accept(IVisitor<T> visitor){
            visitor.Visit(this);
        }
        
    }
}
