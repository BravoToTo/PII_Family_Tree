namespace Library;

public class OldestChildrenVisitor<T> : IVisitor<T> where T : Persona
{
    public int Oldest = 0;
    public void Visit(Node<T> node) {
        if (node.Content.Edad > Oldest)
        {
            this.Oldest = node.Content.Edad;
        }
        foreach (Node<T> item in node.Children)
        {
            item.accept(this);
        }
    }
}