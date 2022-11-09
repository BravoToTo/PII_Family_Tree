namespace Library;

public class AgeSumVisitor<T> : IVisitor<T> where T : Persona 
{
    public int sum = 0;
    public void Visit(Node<T> node) {
        this.sum += node.Content.Edad;
        foreach (Node<T> item in node.Children)
        {
            item.accept(this);
        }
    }
}