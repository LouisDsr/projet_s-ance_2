using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motif_modifiable : MonoBehaviour
{
    public GameObject prefab;
    public GameObject Spere_holder;
    public int number = 20;
    public float radius = 5f;
    public GameObject[] tableau = new GameObject[20];
    private int nombre;
    private float rayon;
    void Start()
    {
        nombre = number;
        rayon = radius;
        for (int i = 0; i < number; i++)
        {
            float angle = i * Mathf.PI * 2 / number;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            tableau[i] = Instantiate(prefab, pos, rot, Spere_holder.transform);
        }
    }
    void Update()
    {
        if (number != nombre || rayon != radius)
        {
            for (int i = 0; i < nombre; i++)
            {
                Destroy(tableau[i]);
            }

            nombre = number;
            rayon = radius;
            tableau = new GameObject[number];
            
            for (int i = 0; i < number; i++)
            {
                float angle = i * Mathf.PI * 2 / number;
                float x = Mathf.Cos(angle) * radius;
                float z = Mathf.Sin(angle) * radius;
                Vector3 pos = transform.position + new Vector3(x, 0, z);
                float angleDegrees = -angle * Mathf.Rad2Deg;
                Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
                tableau[i] = Instantiate(prefab, pos, rot, Spere_holder.transform);
            }
        }
    }
}