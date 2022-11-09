namespace Library;

public interface INode<T>
{
    void accept(IVisitor<T> visitor);
}