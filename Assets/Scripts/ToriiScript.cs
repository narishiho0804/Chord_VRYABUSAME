using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToriiScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // ゴールしたら拍手の音を出す
            // ゴールしたらエフェクトを出す
        }
    }
}
