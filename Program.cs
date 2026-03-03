using System.Text;

public class LinqDemo
{
    public static void printNums(IEnumerable<int> numbers)
    {
        StringBuilder sb = new();

        foreach (int n in numbers)
        {
            sb.AppendLine($"Number: {n}");
        }

        Console.WriteLine(sb.ToString());
    }

    public static void printGames(IEnumerable<Game> games)
    {
        StringBuilder sb = new();

        foreach (Game game in games)
        {
            sb.AppendLine($"Title: {game.Title} - Stock: {game.Stock}");
        }

        Console.WriteLine(sb.ToString());
    }
    public static void filterNums(int[] arr)
    {
        // Uses the IEnumerable interface, which is an array built-in
        // Here we are using Linq query syntax to filter numbers with a WHERE clause
        IEnumerable<int> result = from nums in arr
                                  where nums < 10
                                  select nums;
        printNums(result);
    }

    public static void filterNumsLinqMethods(int[] arr)
    {
        // Result is implicitly inferred here to IEnumerable<int>
        var result = arr.Where(num => num > 5).ToList();

        printNums(result);
    }
    public static void filterGames(List<Game> gamesArr)
    {
        IEnumerable<Game> result = from games in gamesArr
                                   where games.Stock < 5
                                   select games;
        printGames(result);
    }

    public static void filterGamesLinkMethods(List<Game> gamesArr)
    {
        var result = gamesArr.Where(game => game.Stock > 5).ToList<Game>();
        printGames(result);
    }
    public static void Main()
    {
        // In memory array object
        int[] numArr = new[] { 1, 2, 3, 10, 15, 8 };

        // filterNums(numArr);
        // filterNumsLinqMethods(numArr);

        //In-memory List collection
        List<Game> gameStock = new List<Game>() {
            new Game() { GameID = 1, Title = "Mario", Price = 20.00, Stock = 5} ,
            new Game() { GameID = 2, Title = "Contra", Price = 25.00, Stock = 2 } ,
            new Game() { GameID = 3, Title = "Donkey Kong", Price = 10.00, Stock = 10 } ,
            new Game() { GameID = 4, Title = "Pac-man" , Price = 12.00, Stock = 8} ,
            new Game() { GameID = 5, Title = "Space Invaders" , Price = 8.00, Stock = 1 }
        };

        // filterGames(gameStock);
        filterGamesLinkMethods(gameStock);
    }
}

public class Game
{
    public int GameID { get; set; }
    public string Title { get; set; } = string.Empty;
    public double Price { get; set; }
    public int Stock { get; set; }
}