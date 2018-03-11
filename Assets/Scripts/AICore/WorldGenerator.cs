using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour {

    public GameObject worldPrefab;
    private GameObject world;

    public int regionCount;

    public GameObject regionPrefab;
    private List<GameObject> regionList;

    public int villageCountRange;

    public GameObject cityPrefab;
    public GameObject villagePrefab;

    public void GenerateWorld()
    {

        Destroy(world);

        world = Instantiate(worldPrefab);     
    }
}