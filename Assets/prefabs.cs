using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabs : MonoBehaviour
{
    public GameObject sphere;
    public int width;
    public int height;
    void Start()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Instantiate(sphere, new Vector3(j, i, 0), Quaternion.identity);
            }
        }
        
    }
    
}
