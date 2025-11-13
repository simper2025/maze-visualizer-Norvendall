namespace labyrinth;

public class MazeSolver
{
    public List<NodeLink> ExploreMaze(MazeCell start)
    {
        List<NodeLink> retval = [];

        ExploreNode(start, retval);

        return retval;
    }
    public void ExploreNode(MazeCell current, List<NodeLink> list)
    {
        if (current == null) return;

        if (current.North != null)
        {
            var link = new NodeLink(current, "N", current.North);
            if (!list.Contains(link))
            {
                list.Add(link);
                ExploreNode(current.North, list);
            }
        }
        if (current.East != null)
        {
            var link = new NodeLink(current, "E", current.East);
            if (!list.Contains(link))
            {
                list.Add(link);
                ExploreNode(current.East, list);
            }
        }
        if (current.South != null)
        {
            var link = new NodeLink(current, "S", current.South);
            if (!list.Contains(link))
            {
                list.Add(link);
                ExploreNode(current.South, list);
            }
        }
        if (current.West != null)
        {
            var link = new NodeLink(current, "W", current.West);
            if (!list.Contains(link))
            {
                list.Add(link);
                ExploreNode(current.West, list);
            }
        }
    }
}