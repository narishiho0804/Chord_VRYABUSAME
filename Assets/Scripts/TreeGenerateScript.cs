using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerateScript : MonoBehaviour
{
    public GameObject prefab01;
    public GameObject stonePrefab;

    void Start()
    {
        if (prefab01)
        {
            for (int i = 0; i < 30; i++)
            {
                Instantiate(prefab01, new Vector3(i * 4.0F, 0, 7), Quaternion.identity);
            }
            for (int i = 0; i < 30; i++)
            {
                Instantiate(prefab01, new Vector3(i * 4.0F, 0, -7), Quaternion.identity);
            }
        }
        if (stonePrefab)
        {
            for (int i = 0; i < 15; i++)
            {
                Instantiate(stonePrefab, new Vector3(i * 10.0F, 0, 20), Quaternion.identity);
            }
            for (int i = 0; i < 15; i++)
            {
                Instantiate(stonePrefab, new Vector3(i * 10.0F, 0, -20), Quaternion.identity);
            }
        }
        //for (int i = 0; i < 30; i++)
        //{
        //    Instantiate(prefab, new Vector3(i * 3.0F , 0, 1), Quaternion.identity);
        //}
    }
}
