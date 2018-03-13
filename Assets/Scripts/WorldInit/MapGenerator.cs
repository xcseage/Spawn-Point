using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;

public class MapGenerator : MonoBehaviour {


    [Range(0, 100)]
    public int iniChance;

    [Range(1, 8)]
    public int birthLimit;

    [Range(1, 8)]
    public int deathLimit;

    [Range(1, 10)]
    public int time;
    private int count = 0;

    private int[,] terrainMap;

    Vector3Int tmapSize;

    public Tilemap topMap;
    public Tilemap botMap;
    public Tile topTile;
    public Tile botTile;

    int width;
    int height;


    public void doSim(int numR)
    {

        clearMap(false);
        width = tmapSize.x;
        height = tmapSize.y;

        if (terrainMap == null)
        {

            terrainMap = new int[width, height];
            initPos();
        }

        for (int i = 0; i < numR; ++i)
        {
            terrainMap = genTilePos(terrainMap);
        }
    }

    public int [,] genTilePos(int[,] oldMap)
    {

        int[,] newMap = new int[width, height];
        int neighb;
        BoundsInt myB = new BoundsInt(-1, -1, 0, )

        for(int x = 0; x < width; ++x)
        {
            for(int y = 0; y < height; ++y)
            {
                neighb = 0;
            }
        }
    }

    public void initPos()
    {

        for(int x = 0; x < width; ++x)
        {
            for(int y = 0; y < height; ++y)
            {
                terrainMap[x, y] = Random.Range(1, 101) < iniChance ? 1 : 0;
            }
        }
    }
    
	// Update is called once per frame
	void Update () {
		
	}

    void clearMap (bool complete)
    {

        topMap.ClearAllTiles();
        botMap.ClearAllTiles();

        if (complete)
        {
            terrainMap = null;
        }
    }
}
