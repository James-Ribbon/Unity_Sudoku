using System.Drawing;
using Grid.Cell;

namespace Grid
{
    public class SudokuGrid : BaseGrid, IGridGenerator
    {
        private int _gridSize;
        
        public SudokuGrid(int size) : base(size)
        {
            _gridSize = size;
        }

        public void GenerateGrid(int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    GridCells[row, col] = new GridCell();
                }
            }
            
            PopulateGrid();
        }
        
        public override void PopulateGrid()
        {
            for (int row = 0; row < _gridSize; row++)
            {
                for (int col = 0; col < _gridSize; col++)
                {
                    GridCells[row, col].Value = 0;
                }
            }
        }
        
        public ICell[,] GridCells => base.GridCells;
    }
}