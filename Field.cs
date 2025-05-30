using System;
namespace TriVRud
{
	public class Field
	{
		public const int Width = 10;
		public const int Hight = 10;
		public static Cell[,] Cells;
		public static Point Cursor = new Point(0, 0);
		public static Point Selected;

		public Field()
		{
			Cells = new Cell[Hight, Width];
			RandomGenerationCells();
		}

		public void Print()
		{
            Console.Clear();

            for (int y = 0; y < Hight; y++)
			{
				for (int x = 0; x < Width; x++)
				{
					bool isCursor = (Cursor.X == x && Cursor.Y == y);

					bool isSelected = (Selected != null && Selected.X == x && Selected.Y == y);

					Cells[y, x].Print(isCursor, isSelected);
					
					Console.Write(" ");
				}
                Console.WriteLine();
            }
		}

		public void RandomGenerationCells()
		{
			Random random = new Random();

			for (int y = 0; y < Hight; y++)
			{
				for (int x = 0; x < Width; x++)
				{
					CellColors color = (CellColors)random.Next(Enum.GetValues(typeof(CellColors)).Length);

                    Cells[y, x] = new Cell(color);
				}
			}
		}

		public void SelectOrSwap()
		{
			if(Selected == null)
			{
                Selected = new Point(Cursor.Y, Cursor.X);
            }
			else
			{
				int x = Math.Abs(Cursor.X - Selected.X);
				int y = Math.Abs(Cursor.Y - Selected.Y);

				if((x == 1 &&  y == 0) || (x == 0 && y == 1))
				{
					SwapCells(Cursor, Selected);
					Selected = null;
					Print();
				}

			}
			
		}

		private void SwapCells(Point cursor, Point selected)
		{
			Cell temp = Cells[cursor.Y, cursor.X];
			Cells[cursor.Y, cursor.X] = Cells[selected.Y, selected.X];
			Cells[selected.Y, selected.X] = temp;

        }
    }
}