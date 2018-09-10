using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    // parameters
    [SerializeField] int breakableBlocks;  //Serialized for debugging purposes

    // cached reference
    ScreenLoader screenLoader;

    private void Start()
    {
        screenLoader = FindObjectOfType<ScreenLoader>();
    }

    public void CountBlocks()
    {
            breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            screenLoader.NextSceenLoader();
        }
    }
}
