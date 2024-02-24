using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMaker : MonoBehaviour
{
    public GameObject Sand;
    public GameObject Coral;

    public float levelWidth = 20;
    public float levelHeight = 20;
    //public int[] level;
    // Start is called before the first frame update
    void Start()
    {
        float x = -0.5f * levelWidth;
        float y = -0.5f * levelHeight;

        for (int a = 0; a < levelHeight; a++)
        {
            for (int b = 0; b < levelWidth; b++)
            {
                GameObject sand = Instantiate(Sand, new Vector3(x, y, 0f), Quaternion.identity);
                x+=4;
            }
            x = -0.5f * levelWidth;
            y+=4;
        }
    }
}
