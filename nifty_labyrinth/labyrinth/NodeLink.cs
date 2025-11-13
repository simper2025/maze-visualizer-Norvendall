namespace labyrinth;

public record NodeLink(MazeCell From, string Direction, MazeCell To)
{
    public string Label => $"{Direction} to {To.Id}";
}