using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CountDownSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI countText; // 「countText」のテキスト

    [SerializeField]
    private GameObject countTextSize;

    
    [SerializeField]
    private AudioSource audioSource;
  
    [SerializeField]
    private Scenes loadScene;

    public enum Scenes
    {
        Main,
        Main02,
        Main03,
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        countText.text = string.Empty; // 「countText.text = "";」同じ意味
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {

        yield return new WaitForSeconds(2);
        audioSource.Play();
        
        for (int i = 3; i > 0; --i)
        {
            Debug.Log(i);
            countText.text = i.ToString();
            countTextSize.transform.DOScale(new Vector3(2, 2, 2), 1f).SetAutoKill(false);
            yield return new WaitForSeconds(1);
            countTextSize.transform.DORestart();
        }


        countText.text = "GO!";
        countTextSize.transform.DOScale(new Vector3(2, 2, 2), 1f);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(loadScene.ToString());
    }

}
