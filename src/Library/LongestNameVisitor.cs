namespace Library;

public class LongestNameVisitor : IVisitor
{
    private int Length = 0;
    public string Name;
    public void Visit(Node node) {
        if (node.Person.Name.Length > Length)
        {
            this.Length = node.Person.Name.Length;
            this.Name = node.Person.Name;
        }
        foreach (Node item in node.Children)
        {
            item.accept(this);
        }
    }
}