namespace Grid.Cell
{
    public interface ICell
    {
        int Value { get; set; }
        bool IsValid();
    }
}