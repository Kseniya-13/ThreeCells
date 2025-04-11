using System;
namespace TriVRud
{
	public class Cell
	{
        public CellColors Color { get; set; }

        public Cell(CellColors color)
		{
			Color = color;
		}


        public void Print(bool isCursor)
		{
			switch(Color)
			{
				case CellColors.Red:
					Console.BackgroundColor = ConsoleColor.Red;
					break;
				case CellColors.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
				case CellColors.Mugnetto:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
				case CellColors.Blue:
					Console.BackgroundColor = ConsoleColor.Blue;
					break;
				case CellColors.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
					break;
            }

			if(isCursor)
			{
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("[]");
			}
			else
			{
                Console.Write("  ");
            }
			Console.ResetColor();
		}

    }
}

