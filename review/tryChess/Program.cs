using System.Xml;
class Program
{
    public static void Main(string[] args)
    {
        // Dictionary<ChessPiecePlayer, int> dict = new();
        // Player player = new();

        // dict.Add(player.white, 1);

        var numbers = new List<int>() { 10, 20, 30, 40, 10 };

        Console.WriteLine($"{numbers[1]}");
        numbers.Remove(10); // removes the first 10 from a list
        numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)
        //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

        Console.WriteLine($"{numbers[1]}");

        // foreach (var el in numbers)
        //     Console.Write(el); //prints 20 30

    }

    class Player
    {
        public ChessPiecePlayer white = new();
        public ChessPiecePlayer black = new();
        public Dictionary<ChessPiece, Coordinate> dict = new();
        public Coordinate coordinate = new();

        public void addActivePosition()
        {
            dict.Add(white.knights[0], coordinate);
        }
    }

    class ChessPiecePlayer
    {
        public King king = new();
        public List<Knight> knights = new();

        public ChessPiecePlayer()
        {
            knights.Add(new Knight());
            knights.Add(new Knight());
        }
    }
    class ChessPiece
    {

    }

    class Knight : ChessPiece
    {

    }

    class Rook : ChessPiece
    {

    }

    class King : ChessPiece
    {

    }

    class Coordinate
    {

    }
}
