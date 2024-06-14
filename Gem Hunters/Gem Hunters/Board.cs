public class Board
{
    public Cell[,] Grid { get; set; }
    private const int Size = 6;

    public Board()
    {
        Grid = new Cell[Size, Size];

        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Grid[i, j] = new Cell("-");
            }
        }

        // Place Players
        Grid[0, 0].Occupant = "P1";
        Grid[Size - 1, Size - 1].Occupant = "P2";

        // Place Gems and Obstacles randomly
        PlaceRandomItems("G", 5);
        PlaceRandomItems("O", 5);
    }

    private void PlaceRandomItems(string item, int count)
    {
        Random rand = new Random();
        int placed = 0;
        while (placed < count)
        {
            int x = rand.Next(Size);
            int y = rand.Next(Size);
            if (Grid[x, y].Occupant == "-")
            {
                Grid[x, y].Occupant = item;
                placed++;
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write(Grid[i, j].Occupant + " ");
            }
            Console.WriteLine();
        }
    }
}