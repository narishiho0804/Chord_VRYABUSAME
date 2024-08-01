using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerateScript : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 3), Quaternion.identity);
        }
    }
}
