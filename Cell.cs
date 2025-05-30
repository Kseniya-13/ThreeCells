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


        public void Print(bool isCursor, bool isSelected)
		{
            Console.ForegroundColor = ConsoleColor.Black;

            switch (Color)
			{
				case CellColors.Red:
					Console.BackgroundColor = ConsoleColor.Red;
					break;
				case CellColors.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
				case CellColors.Magento:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
				case CellColors.Blue:
					Console.BackgroundColor = ConsoleColor.Blue;
					break;
				case CellColors.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
					break;
            }

			if(isSelected)
			{
                Console.Write("()");
            }
			else if(isCursor)
			{
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

