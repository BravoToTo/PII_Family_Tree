namespace Library;

public class OldestChildrenVisitor : IVisitor
{
    public int Oldest = 0;
    public void Visit(Node node) {
        if (node.Person.Edad > Oldest)
        {
            this.Oldest = node.Person.Edad;
        }
        foreach (Node item in node.Children)
        {
            item.accept(this);
        }
    }
}