using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour {

    public GameObject worldPrefab;
    private GameObject world;

    public void GenerateWorld()
    {

        Destroy(world);

        world = Instantiate(worldPrefab);
    }


}