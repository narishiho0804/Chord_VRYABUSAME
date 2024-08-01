using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneSwitch : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "countdown":
                SceneManager.LoadScene("CountDown");
                break;

            case "countdown2":
                SceneManager.LoadScene("CountDown2");
                break;

            case "countdown3":
                SceneManager.LoadScene("CountDown3");
                break;

            case "Title":
                SceneManager.LoadScene("Title");
                break;

        }
    }
}
