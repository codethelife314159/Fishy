using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMaker : MonoBehaviour
{
    public GameObject Sand;
    public GameObject Coral;

    //Decor Things:
    public GameObject CanRed;
    public GameObject CanBlue;
    public GameObject CanGreen;
    public GameObject CanPink;
    public GameObject GlassBottle;
    public GameObject SandDollar;
    public GameObject BlueShell;
    public GameObject PinkShell;
    public GameObject ScallopShell;

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
                x += 4;
            }
            x = -0.5f * levelWidth;
            y += 4;
        }


        for (int c = 0; c < 900; c++)
        {
            x = Random.Range(-100, 100);
            y = Random.Range(-100, 100);

            RandomGenThing(x, y);
        }
    }

    public void RandomGenThing(float x, float y)
    {
        int rand = Random.Range(1, 9);
        if(rand == 1)
        {
            GameObject RedCan = Instantiate(CanRed, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if(rand == 2)
        {
            GameObject BlueCan = Instantiate(CanBlue, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if(rand == 3)
        {
            GameObject GreenCan = Instantiate(CanGreen, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if (rand == 4)
        {
            GameObject PinkCan = Instantiate(CanPink, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if (rand == 5)
        {
            GameObject Bottle = Instantiate(GlassBottle, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if (rand == 6)
        {
            GameObject Scallop = Instantiate(ScallopShell, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if (rand == 7)
        {
            GameObject ShellPink = Instantiate(PinkShell, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if (rand == 8)
        {
            GameObject ShellBlue = Instantiate(BlueShell, new Vector3(x, y, 0f), Quaternion.identity);
        }
        if (rand == 9)
        {
            GameObject sandDollar = Instantiate(SandDollar, new Vector3(x, y, 0f), Quaternion.identity);
        }
    }
}