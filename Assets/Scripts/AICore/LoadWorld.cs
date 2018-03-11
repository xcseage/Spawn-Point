using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWorld : MonoBehaviour {

    public int regionCount;

    public GameObject regionPrefab;

    void load()
    {

        for (int i = 0; i < regionCount; ++i)
        {
            GameObject region = Instantiate(regionPrefab);
            region.transform.parent = this.gameObject.transform;
            region.GetComponent<LoadRegion>().load();
        }
    }
}