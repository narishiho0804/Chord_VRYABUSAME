using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScript : MonoBehaviour
{
    [SerializeField]
    private AudioClip sound1;
    AudioSource audioSource;

    private void Start()
    {
        // Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 音を(sound1)鳴らす
        audioSource.PlayOneShot(sound1);
        Debug.Log("当たった");
    }
}
