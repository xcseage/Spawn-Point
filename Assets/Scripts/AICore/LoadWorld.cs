using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadWorld : MonoBehaviour {

    public int regionCount;

    public GameObject regionPrefab;

    private void Start()
    {

        for (int i = 0; i < regionCount; ++i)
        {
            GameObject region = Instantiate(regionPrefab);
            region.transform.parent = this.gameObject.transform;
        }
    }
}