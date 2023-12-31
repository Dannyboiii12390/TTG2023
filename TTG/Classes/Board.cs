﻿using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using TTG.Helpers;

namespace TTG.Classes
{
    public class Board
    {
        public List<List<Cell>> Cells { get; private set; } = new List<List<Cell>>();

        private int cellsWide = 8;
        private int cellsHigh = 6;
        public float cellWidth { get; private set; }
        public float cellHeight { get; private set; }
        public int NumberOfDroughtCells { get { return GetNumberOfDroughtCells(); } }
        public List<PlaceableObject> objects 
        { 
            get 
            { 
                List<PlaceableObject> placeableObjects = new List<PlaceableObject>();
                foreach(List<Cell> list in Cells) 
                { 
                    foreach (Cell cell in list)
                    {
                        if (cell.Object == null)
                        {
                            continue;
                        }
                        placeableObjects.Add(cell.Object);
                    } 
                }
                return placeableObjects;
            } 
        }


        public Vector2 offset = new Vector2(160, 0);

        public Board()
        {
            cellWidth = 80;
            cellHeight = 80;

            for (int i = 0; i < cellsHigh; i++)
            {
                List<Cell> list = new List<Cell>();
                for (int j = 0; j < cellsWide; j++)
                {
                    Color color;
                    if ((i + j) % 2 == 0) // is even ws
                    {
                        color = Color.Green;
                    }
                    else
                    {
                        color = Color.DarkGreen;
                    }
                    Square square = new Square(j * cellWidth + offset.X, i * cellHeight + offset.Y, cellWidth, cellHeight, color);
                    list.Add(new Cell(square));
                }
                Cells.Add(list);
            }
        }
        public Cell GetCell(int i, int j)
        {
            try
            {
                return Cells[j][i];
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
            
            
        }
        public Cell GetCell(Vector2 pos)
        {
            int i = (int)(pos.X / cellWidth);
            int j = (int)(pos.Y / cellHeight);
            return GetCell(i - 2, j);
        }
        public void Draw(ShapeBatcher shapeBatcher)
        {
            foreach (List<Cell> list in Cells)
            {
                foreach (Cell cell in list)
                {
                    shapeBatcher.HelperDrawSquare(cell.Square);
                }
            }
        }
        private int GetNumberOfDroughtCells()
        {
            int Count = 0;
            foreach (List<Cell> list in Cells)
            {
                foreach (Cell cell in list)
                {
                    if (cell.Drought)
                    {
                        Count++;
                    }
                }
            }
            return Count;

        }
        public void updateDroughtTiles(Zombie entity)
        {
            foreach (List<Cell> list in Cells)
            {
                foreach (Cell cell in list)
                {
                    if (cell.Square.isInside(entity.Position))
                    {
                        cell.Drought = true;
                        cell.Square.ChangeColour(Color.Tan);
                    }
                }
            }
        }
        public void FixDrought(Vector2 mousePosition)
        {
            Cell cell = GetCell(mousePosition);
            cell.Drought = false;
            cell.Square.ChangeColour(cell.defaultColour);
        }


    }
}
