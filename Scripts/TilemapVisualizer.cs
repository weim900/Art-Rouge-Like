using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;  // Typo fix: UniteEngine.Tilemaps → UnityEngine.Tilemaps

public class TilemapVisualizer : MonoBehaviour
{
    [SerializeField]  // Typo fix: SerializedField → SerializeField
    private Tilemap floorTilemap, wallTilemap;

    [SerializeField]
    private TileBase floorTile, wallTop;  

    public void PaintFloorTiles(IEnumerable<Vector2Int> floorPositions)
    {
        PaintTiles(floorPositions, floorTilemap, floorTile);
    }

    private void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase tile)
    {
        foreach (var position in positions)
        {
            PaintSingleTile(tilemap, tile, position);
        }
    }

    internal void PaintSingleBasicWall(Vector2Int position)
    {
PaintSingleTile(wallTilemap, wallTop, position);
    }


    private void PaintSingleTile(Tilemap tilemap, TileBase tile, Vector2Int position)
    {
        // Typo fix: WorldtoCell → WorldToCell
        var tilePosition = new Vector3Int(position.x, position.y, 0);
        tilemap.SetTile(tilePosition, tile);
    }

    public void Clear()
    {
        floorTilemap.ClearAllTiles();
        wallTilemap.ClearAllTiles();
    }

}
