using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ProceduralGenerationAlgorithm shouldn't inherit from MonoBehaviour if it's static
public static class ProceduralGenerationAlgorithm
{
    // Simple random walk algorithm
    public static HashSet<Vector2Int> SimpleRandomWalk(Vector2Int startPosition, int walkLength)
    {
        HashSet<Vector2Int> path = new HashSet<Vector2Int>();

        // Typo fix: startPostiion → startPosition
        path.Add(startPosition);
        var previousPosition = startPosition;

        for (int i = 0; i < walkLength; i++)
        {
            var newPosition = previousPosition + Direction2D.GetRandomCardinalDirection();
            path.Add(newPosition);
            previousPosition = newPosition;
        }

        return path;
    }
}

public static class Direction2D
{
    // Typo fix: List,Vector2Int → List<Vector2Int>
    public static List<Vector2Int> cardinalDirectionList = new List<Vector2Int>
    {
        new Vector2Int(0,1),  // UP
        new Vector2Int(1,0),  // RIGHT
        new Vector2Int(0,-1), // DOWN
        new Vector2Int(-1,0)  // LEFT
    };

    // Corrected GetRandomCardinalDirection function
    public static Vector2Int GetRandomCardinalDirection()
    {
        // Random.Range for int is inclusive min, exclusive max — and no need to call GetRandomCardinalDirection() recursively.
        int index = Random.Range(0, cardinalDirectionList.Count);
        return cardinalDirectionList[index];
    }
}
