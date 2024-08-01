using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PingPong : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro scoretext;

    [SerializeField]
    private TextMeshPro ScoreResult;

    private float nowPosi;
    private bool isClear =false;
    private int score = 0;

    public bool IsClear { get => isClear; set => isClear = value; }

    void Start()
    {
        nowPosi = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isClear);
        if (isClear) return;
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z); // プレイヤーを上下に動かす。
    }
    public void scoreUp(int scorehit)
    {
        score += scorehit; // スコアを＋１加算する
        scoretext.text = string.Format("Score:{0}", score);
        ScoreResult.text = string.Format(score + "個当たった");// 「何個中何個当たった」か表示する
    }    
}
