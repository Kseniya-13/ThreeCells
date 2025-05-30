namespace TriVRud;
class Program
{
    public static Field _field = new Field();
    public static bool _isGameRunning = true;
    static void Main(string[] args)
    {
        do
        { 
            _field.Print();
            HandleInput();
        } while (true);
    }

    private static void HandleInput()
    {
        var key = Console.ReadKey().Key;

        switch(key)
        {
            case ConsoleKey.UpArrow:
                if (Field.Cursor.Y > 0)
                {
                    Field.Cursor.Y--;
                }
                break;

            case ConsoleKey.DownArrow:
                if(Field.Cursor.Y + 1 < Field.Hight)
                {
                    Field.Cursor.Y++;
                }
                break;

            case ConsoleKey.LeftArrow:
                if(Field.Cursor.X > 0)
                {
                    Field.Cursor.X--;
                }
                break;

            case ConsoleKey.RightArrow:
                if(Field.Cursor.X + 1 < Field.Width)
                {
                    Field.Cursor.X++;
                }
                break;

            case ConsoleKey.Spacebar:
                _field.SelectOrSwap();
                break;
        }
    }
}

