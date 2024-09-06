namespace Grid.Cell
{
    public class GridCell : ICell
    {
        public int Value { get; set; }
        
        public bool IsValid()
        {
            return Value is >= 1 and <= 9;
        }
    }
}