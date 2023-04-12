# Piece
`var piece = new Piece(PieceDescription description)`
## Description
Responsible for defining a piece's description, such as name, moves, color, and lives.
## Types
### `PieceDescription`
```
color: PieceColor
moves: List<Move>
lives: Int
statusModifiers: List<StatusModifier>
name: Name
```
### `GetMoves`
`public delegate Coords[] GetMoves(Coords initialSquare, int layoutSize);`
## Methods
### `Piece.Kill()`
Sets `Piece.lives` to `0`
### `Piece.Revive(Int lives)`
Sets `Piece.lives` to `lives`. If no param is passed, it should set it to `1`.
### `Piece.IsAlive()`
Returns a boolean true if `Piece.Lives > 0`.
### `Piece.AddMoves(Move move)`
Adds a move function to `Piece.Moves`
## Imported functions
### Moves functions
The `moves` property is a list of coords that the piece can move to given an initial square and layout size. This means you can combine two or more `Move` functions for a piece. For example, you can combine a knight and a rook to get a chancellor, or a knight and a rook to make an archbishop, which are both common combinations in non-standard chess games. But, you can also create new moves that are not taken from preset functions, by just adding an anonymous function that has checks as a `GetMoves` 