namespace Library;

public class LongestNameVisitor<T> : IVisitor<T> where T : Persona
{
    private int Length = 0;
    public string Name;
    public void Visit(Node<T> node) {
        if (node.Content.Name.Length > Length)
        {
            this.Length = node.Content.Name.Length;
            this.Name = node.Content.Name;
        }
        foreach (Node<T> item in node.Children)
        {
            item.accept(this);
        }
    }
}