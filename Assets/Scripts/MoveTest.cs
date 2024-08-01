using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTest : MonoBehaviour
{
    //public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMove(new Vector3(100f, 0f, 0f),50f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
