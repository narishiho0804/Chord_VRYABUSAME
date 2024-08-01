using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceGenerateScript : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab01;

    [SerializeField]
    private GameObject prefab02;

    void Start()
    {
        if (prefab01)
        {
            for (int i = 0; i < 24; i++)
            {
                Instantiate(prefab01, new Vector3(i * 4.0F, 0, 1), Quaternion.identity);
            }
        }
        if (prefab02)
        {
            for (int i = 0; i < 24; i++)
            {
                Instantiate(prefab02, new Vector3(i * 4.0F, 0, -1), Quaternion.identity);
            }
        }
        
    }
}
