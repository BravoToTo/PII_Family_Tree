namespace Library;

public class OldestChildrenVisitor : IVisitor<Persona>
{
    private int Oldest = 0;
    public void Visit(Node<Persona> node) {
        if (node.Content.Edad > Oldest)
        {
            this.Oldest = node.Content.Edad;
        }
        foreach (Node<Persona> item in node.Children)
        {
            item.accept(this);
        }
    }

    public int getOldest(Node<Persona> FirstNode) {
        FirstNode.accept(this);
        return this.Oldest;
    }
}