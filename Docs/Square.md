# Square
`var square = new Square(SquareDescription description)`
## Description
Responsible for handling the state of one square, like adding/removing piece objects, element objects, as well as the current active state of the square and its color
## Types
### `SquareDescription`
Contains properties:
```
isActive: Boolean
color: SquareColor
piece: Piece || null
element: List<Element>
```
## Properties
### `Boolean isActive`
Square is active or not (active means playable in this context)
### `SquareColor color`
Color of the square
### `Piece piece`
Holds a Piece() instance, in case there's one in the square. If there's no piece, the prop is null.
### `Element element`
Holds a Element() instance, in case there's one in the square. If there's no element, the prop is null.
## Methods
### `Square.activateSquare()`
Sets Square.IsActive to true
### `Square.deactivateSquare()`
Sets Square.IsActive to false
### `Square.toggleSquare()`
Toggles Square.IsActive to opposite state
### `Square.AddPiece(Piece piece)`
Sets a piece to the square. If there's already one there, it overwrites it.
### `Square.RemovePiece()`
Removes a piece from the square.
### `Square.AddElement(Element element)`
Adds an element to the square. 
### `Square.RemoveElement()`
Removes an element to the square.
