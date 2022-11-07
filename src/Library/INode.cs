namespace Library;

public interface INode
{
    void accept(IVisitor visitor);
}