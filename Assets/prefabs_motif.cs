using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabs_motif : MonoBehaviour
{
    public GameObject prefab;
    public int number = 20;
    public float radius = 5f;
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            float angle = i * Mathf.PI * 2 / number;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(prefab, pos, rot);
        }
    }
}