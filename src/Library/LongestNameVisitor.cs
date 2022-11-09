namespace Library;

public class LongestNameVisitor : IVisitor<Persona>
{
    private int Length = 0;
    private string Name;
    public void Visit(Node<Persona> node) {
        if (node.Content.Name.Length > Length)
        {
            this.Length = node.Content.Name.Length;
            this.Name = node.Content.Name;
        }
        foreach (Node<Persona> item in node.Children)
        {
            item.accept(this);
        }
    }

    public string getLongestName(Node<Persona> FirstNode) {
        FirstNode.accept(this);
        return this.Name;
    }
}