# Gem Hunters

"Gem Hunters" is a console-based 2D game where two players compete to collect the most gems on a 6x6 board. The game ends after each player has taken 15 turns, and the player with the most gems wins.

## Game Rules

- **Board**: 6x6 grid
- **Players**: 
  - Player 1 (P1) starts at (0,0)
  - Player 2 (P2) starts at (5,5)
- **Gems**: Randomly placed on the board
- **Obstacles**: Randomly placed and impassable
- **Display**: 
  - "P1" and "P2" for players
  - "G" for gems
  - "O" for obstacles
  - "-" for empty spaces
- **Movement**:
  - Input "U", "D", "L", "R" to move
  - Move up, down, left, or right by one square
  - No diagonal moves or moves through obstacles
- **Collecting Gems**:
  - Move onto a gem to collect it
  - The square becomes empty
- **Turns**:
  - Alternate turns, 15 each
  - Game ends after 30 moves
- **Winning**:
  - Most gems collected wins
  - Tie if both have the same number of gems

## Classes

### Position
- `int X`, `int Y`
- `Position(int x, int y)`

### Player
- `string Name`
- `Position Position`
- `int GemCount`
- `Move(char direction)`

### Cell
- `string Occupant`

### Board
- `Cell[,] Grid`
- `Board()`
- `Display()`
- `IsValidMove(Player player, char direction)`
- `CollectGem(Player player)`
- `UpdatePlayerPosition(Player player, char direction)`

### Game
- `Board Board`
- `Player Player1`
- `Player Player2`
- `Player CurrentTurn`
- `int TotalTurns`
- `Game()`
- `Start()`
- `SwitchTurn()`
- `IsGameOver()`
- `AnnounceWinner()`

## Running the Game

1. Clone or download the source code.
2. Open in a C# development environment.
3. Build and run the project.
4. Follow on-screen instructions.
