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
        if (collision.gameObject.tag == "Arrow") // ����Arrow�^�O�ɓ���������
        {
            Debug.Log("hit" + score);

            soundSE.Play(); // �usound�v��SE���Đ�����
            pingPong.scoreUp(1);

            this.gameObject.SetActive(false); // �I�ɖ����������I�͔�\���ɂ���
        }
    }
}
