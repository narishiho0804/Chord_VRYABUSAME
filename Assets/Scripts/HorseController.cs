using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorseController : MonoBehaviour
{
    [SerializeField]
    private AudioSource sound1;

    [SerializeField]
    private PingPong pingPong;

    private AudioSource audioSource;
    
    void  Start()
    {
        // AudioSource‚ğæ“¾‚·‚é
        audioSource = GetComponent<AudioSource>();
        // x•ûŒü‚ÉŒü‚©‚¤
        
        this.transform.DOMove(new Vector3(100f, 0f, 0f), 50f); // ‚˜‚É”n‚ªi‚Ş

        audioSource.Play();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            audioSource.Stop();
        }
    }

    public void GameClear()
    {
        pingPong.IsClear = true;@// pingPong‚Ì’†‚ÌIsClear‚ğtrue‚É‚·‚é
    }
    
}
