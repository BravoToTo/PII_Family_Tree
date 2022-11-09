namespace Library;

public class AgeSumVisitor : IVisitor<Persona> 
{
    public int sum = 0;
    public void Visit(Node<Persona> node) {
        this.sum += node.Content.Edad;
        foreach (Node<Persona> item in node.Children)
        {
            item.accept(this);
        }
    }
}