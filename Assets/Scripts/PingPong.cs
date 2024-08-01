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
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z); // �v���C���[���㉺�ɓ������B
    }
    public void scoreUp(int scorehit)
    {
        score += scorehit; // �X�R�A���{�P���Z����
        scoretext.text = string.Format("Score:{0}", score);
        ScoreResult.text = string.Format(score + "��������");// �u���������������v���\������
    }    
}
