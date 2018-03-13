using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour{

    public GameObject worldPrefab;
    private GameObject world;


    WorldGenerator()
    {

        // Destroy(world);

        world = Instantiate(worldPrefab);
    }
}