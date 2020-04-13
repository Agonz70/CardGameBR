using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    int TerrainType;

    Card isCard;
    public int currentCardHP;
    Player isPlayer;
    bool Occupied = false;
    public int Ownership;

    public Vector3 tilePosition;

    public Sprite DefaultTerrain;
    public Sprite GrassTerrain;
    public Sprite LavaTerrain;
    public Sprite WaterTerrain;

    public SpriteRenderer SR;

    public void SetTileTerrain(int terrain){
        TerrainType = terrain;
        switch(terrain){
            case 0:
            //Default tile
            SR.sprite = DefaultTerrain;
            break;
            case 1:
            SR.sprite = LavaTerrain;
            //Fire Tile
            break;
            case 2:
            SR.sprite = WaterTerrain;

            //Water Tile
            break;
            case 3:
            SR.sprite = GrassTerrain;
            //Grass Tile
            break;
            default:
            break;

        }
    }
}
