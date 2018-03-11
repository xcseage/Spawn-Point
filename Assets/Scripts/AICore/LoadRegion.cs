using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadRegion : MonoBehaviour
{

    public int villageCountRange;

    public GameObject cityPrefab;
    public GameObject villagePrefab;

    public void load()
    {

        GameObject city = Instantiate(cityPrefab);

        int villageCount = Random.Range(1, villageCountRange);

        for (int i = 0; i < villageCount; ++i)
        {

            GameObject village = Instantiate(villagePrefab);
            village.transform.parent = this.gameObject.transform;
        }
    }
}