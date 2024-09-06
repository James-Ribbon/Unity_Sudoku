using UnityEngine;
using Grid;

namespace InputHandler
{
    public class InputHandler : MonoBehaviour
    {
        private SudokuGrid sudokuGrid;

        public void SetGrid(SudokuGrid grid)
        {
            sudokuGrid = grid;
        }
        
        public void OnCellValueChanged(int row, int col, int newValue)
        {
            if (sudokuGrid.GridCells[row, col].IsValid())
            {
                sudokuGrid.GridCells[row, col].Value = newValue;
            }
        }
    }
}