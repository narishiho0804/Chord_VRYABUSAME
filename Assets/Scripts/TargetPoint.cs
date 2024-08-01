using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetPoint : MonoBehaviour
{
    [SerializeField]
    private AudioSource soundSE;

    private int score = 0;

    PingPong pingPong;

    void Start()
    {
        var XROrigin = GameObject.Find("XR Origin");
        pingPong = XROrigin.GetComponent<PingPong>();

        soundSE = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        soundSE.Play();
        if (collision.gameObject.tag == "Arrow") // もしArrowタグに当たったら
        {
            Debug.Log("hit" + score);

            soundSE.Play(); // 「sound」のSEを再生する
            pingPong.scoreUp(1);

            this.gameObject.SetActive(false); // 的に矢が当たったら的は非表示にする
        }
    }
}
