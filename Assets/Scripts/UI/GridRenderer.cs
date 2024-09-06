using System;
using Grid;
using UnityEngine;

namespace UI
{
    public class GridRenderer : MonoBehaviour
    {
        public GameObject cellPrefab;
        private SudokuGrid _sudokuGrid;
        private int _gridSize = 9;

        private void Start()
        {
            _sudokuGrid = new SudokuGrid(_gridSize);
            _sudokuGrid.GenerateGrid(_gridSize);

            RenderGrid();
        }

        private void RenderGrid()
        {
            for (int row = 0; row < _gridSize; row++)
            {
                for (int col = 0; col < _gridSize; col++)
                {
                    GameObject cellObject = Instantiate(cellPrefab, new Vector2(col, -row), Quaternion.identity, gameObject.transform);
                    CellUI cellUI = cellObject.GetComponent<CellUI>();
                    cellUI.Initialise(_sudokuGrid, row, col); // Initialize with grid reference and position
                }
            }
        }
    }
}