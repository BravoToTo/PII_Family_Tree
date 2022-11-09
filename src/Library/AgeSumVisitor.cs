namespace Library;

public class AgeSumVisitor : IVisitor<Persona> 
{
    private int sum = 0;
    public void Visit(Node<Persona> node) {
        this.sum += node.Content.Edad;
        foreach (Node<Persona> item in node.Children)
        {
            item.accept(this);
        }
    }

    public int getAgeSum(Node<Persona> FirstNode) {
        FirstNode.accept(this);
        return this.sum;
    }
}