using System;
namespace TriVRud
{
	public class Field
	{
		public const int Width = 10;
		public const int Hight = 10;
		public static Cell[,] Cells;
		public static Point Cursor = new Point(0, 0);

		public Field()
		{
			Cells = new Cell[Hight, Width];
			RandomGenerationCells();
		}

		public void Print()
		{
			bool isCursor = false;
			for (int y = 0; y < Hight; y++)
			{
				for (int x = 0; x < Width; x++)
				{
					if(Cursor.X == x && Cursor.Y == y)
					{
						isCursor = true;
					}

					Cells[y, x].Print(isCursor);
					
					Console.Write(" ");

					isCursor = false;
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
					Cells[y, x] = new Cell((CellColors)random.Next(Enum.GetValues(typeof(CellColors)).Length));
				}
			}
		}
	}
}