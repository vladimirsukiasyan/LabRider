namespace Lab3
{
    public interface IMatrixCheckEmpty<T>
    {
        T getEmptyElement();
    
        bool checkEmptyElement(T element);
    }
}