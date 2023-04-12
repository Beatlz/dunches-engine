# Dunchess API
## Types
### Coords `System.ValueTuple<int, int>`
Tuple that takes in two values for X and Y components
## Classes
### Dungeon
Responsible for managing the state of the layout.
Instantiated as `Dungeon(Dictionary<Coords, Square> layout)` (parameter is optional)
#### Properties
`Dictionary<Coords, Square> Dungeon.layout`
#### Methods
##### `Dungeon.LayoutSize()`
Returns a number with the linear size of the dungeon (E.g., if the dungeon has 64 squares, meaning it's 8x8, this method returns an `8`)
##### `Dungeon.GetSquare(Coords)`
Returns the dungeon instance held in a given set of coords. Returns `null` if it's empty.
##### `Dungeon.SetSquare(Coords, Square)`
Sets a Square instance in a given set of coords. Overwrites a square in the layout if it's already occupied.
##### `Dungeon.HasSquare(Coords)`
Returns a boolean if a square from the layout is occupied by the given coords.