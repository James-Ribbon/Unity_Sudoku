using Grid.Cell;
using UnityEditor.Compilation;

namespace Grid
{
    public abstract class BaseGrid
    {
        protected ICell[,] GridCells;

        public BaseGrid(int gridSize)
        {
            GridCells = new ICell[gridSize, gridSize];
        }

        public abstract void PopulateGrid();
    }
}