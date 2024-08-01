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
        // Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ‰¹‚ð(sound1)–Â‚ç‚·
        audioSource.PlayOneShot(sound1);
        Debug.Log("“–‚½‚Á‚½");
    }
}
