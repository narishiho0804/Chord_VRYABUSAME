using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro gameGoalText; // �uclearText�v��錾

    [SerializeField]
    private TextMeshPro scoreText;

    [SerializeField]
    private GameObject MainTargetGenerate;

    [SerializeField]
    private�@GameObject TitleTargetGenerate;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") // Player�^�O�ɓ���������
        {
            collision.gameObject.GetComponent<HorseController>().GameClear();
            
            StartCoroutine(GoalCler());
            
        }
    }

    IEnumerator GoalCler()
    {
        gameGoalText.gameObject.SetActive(true); // scoreClearText��\������B

        MainTargetGenerate.gameObject.SetActive(true); // MainTargetGenerate��\������B

        TitleTargetGenerate.gameObject.SetActive(true); // TiletargetGenerate��\������B

        scoreText.gameObject.SetActive(false); // scoreText���\������B

        yield return new WaitForSeconds(5f); // 5�b�҂�

        Destroy(gameGoalText.gameObject); // scoreClearText�������܂��B
    }
}