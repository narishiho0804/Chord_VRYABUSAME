using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject taget1;
    public GameObject taget2;
    // Start is called before the first frame update
    void Start()
    {
        taget1.transform.DOMove(new Vector3(2f, 0f, 0f), 50f).SetLoops(5, LoopType.Yoyo);

        taget2.transform.DOMove(new Vector3(2f, 0f, 3f), 10f).SetLoops(5, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
