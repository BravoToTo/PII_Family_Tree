namespace Library;

public class AgeSumVisitor: IVisitor
{
    public int sum = 0;
    public void Visit(Node node) {
        this.sum += node.Person.Edad;
        foreach (Node item in node.Children)
        {
            item.accept(this);
        }
    }
}