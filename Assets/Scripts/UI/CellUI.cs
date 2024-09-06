using System;
using Grid;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CellUI : MonoBehaviour
    {
        private Text cellText;
        private int _row, _col;
        private SudokuGrid _sudokuGrid;

        private void Awake()
        {
            cellText = GetComponentInChildren<Text>();
        }

        public void Initialise(SudokuGrid grid, int row, int col)
        {
            this._sudokuGrid = grid;
            this._row = row;
            this._col = col;
            UpdateCell();
        }

        public void UpdateCell()
        {
            int value = _sudokuGrid.GridCells[_row, _col].Value;
            cellText.text = "9";//value == 0 ? "" : value.ToString();
        }
    }
}