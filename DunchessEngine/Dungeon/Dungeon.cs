namespace DunchessEngine
{
    using Coords = System.ValueTuple<int, int>;

    public class Dungeon
    {
        private readonly Dictionary<Coords, Square> _layout;

        public Dungeon()
        {
            _layout = new Dictionary<Coords, Square>();
        }

        public void SetSquare(Coords coords, Square square)
        {
            _layout[coords] = square;
        }

        public Square GetSquare(Coords coords)
        {
            if (_layout.TryGetValue(coords, out Square square))
            {
                return square;
            }

            return null;
        }

        // ... other methods for working with squares and the layout ...
    }
}