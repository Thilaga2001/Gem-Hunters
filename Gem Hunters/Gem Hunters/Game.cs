

public class Game
{
    public Board Board { get; set; }
    public Player Player1 { get; set; }
    public Player Player2 { get; set; }
    public Player CurrentTurn { get; set; }
    public int TotalTurns { get; set; }

    public Game()
    {
        Board = new Board();
        Player1 = new Player("P1", new Position(0, 0));
        Player2 = new Player("P2", new Position(5, 5));
        CurrentTurn = Player1;
        TotalTurns = 0;
    }

    public void Start()
    {
        while (!IsGameOver())
        {
            Console.Clear();
            Board.Display();
            Console.WriteLine($"{CurrentTurn.Name}'s turn. Gems collected: {CurrentTurn.GemCount}\n");
            Console.WriteLine("P1's no of Gem Collected: " +Player1.GemCount);
            Console.WriteLine("P2's no of Gem Collected: " + Player2.GemCount);
            Console.WriteLine("No of turns remaining: "+ (30-TotalTurns));
            Console.Write("Enter move (U/D/L/R): ");
            char move ='a';

                try
            {
                move = Console.ReadLine().ToUpper()[0];
         
           
                if (Board.IsValidMove(CurrentTurn, move))
            {
                Board.UpdatePlayerPosition(CurrentTurn, move);
                TotalTurns++;
                SwitchTurn();
            }
            else
            {
                Console.WriteLine("Invalid move! Try again.");
                Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid move! Try again.");
                Console.ReadKey();
            };
        }
        AnnounceWinner();
    }

    private void SwitchTurn()
    {
        CurrentTurn = (CurrentTurn == Player1) ? Player2 : Player1;

    }

    private bool IsGameOver()
    {
        return TotalTurns >= 30;
    }

    private void AnnounceWinner()
    {
        Console.Clear();
        Board.Display();
        Console.WriteLine($"Game Over! P1 Gems: {Player1.GemCount}, P2 Gems: {Player2.GemCount}");

        if (Player1.GemCount > Player2.GemCount)
        {
            Console.WriteLine("Player 1 Wins!");
        }
        else if (Player1.GemCount < Player2.GemCount)
        {
            Console.WriteLine("Player 2 Wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}