using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro gameGoalText; // 「clearText」を宣言

    [SerializeField]
    private TextMeshPro scoreText;

    [SerializeField]
    private GameObject MainTargetGenerate;

    [SerializeField]
    private　GameObject TitleTargetGenerate;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") // Playerタグに当たったら
        {
            collision.gameObject.GetComponent<HorseController>().GameClear();
            
            StartCoroutine(GoalCler());
            
        }
    }

    IEnumerator GoalCler()
    {
        gameGoalText.gameObject.SetActive(true); // scoreClearTextを表示する。

        MainTargetGenerate.gameObject.SetActive(true); // MainTargetGenerateを表示する。

        TitleTargetGenerate.gameObject.SetActive(true); // TiletargetGenerateを表示する。

        scoreText.gameObject.SetActive(false); // scoreTextを非表示する。

        yield return new WaitForSeconds(5f); // 5秒待つ

        Destroy(gameGoalText.gameObject); // scoreClearTextを消します。
    }
}