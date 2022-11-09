namespace Library;

public class OldestChildrenVisitor : IVisitor<Persona>
{
    public int Oldest = 0;
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
}