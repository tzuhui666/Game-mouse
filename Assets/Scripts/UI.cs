using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public float totalTime = 120f;  // �˼ƭp�ɪ��`�ɶ�
    public Text Time;    // �Ω���ܳѾl�ɶ���UI Text����
    public Text Score;
    public Text Content;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown());
    }

    private IEnumerator StartCountdown()
    {
        float timeRemaining = totalTime;

        while (timeRemaining > 0)
        {
            // ��s��ܮɶ�
            Time.text = "time\n" + timeRemaining.ToString("F0");

            // ���ݤ@��
            yield return new WaitForSeconds(1f);

            // ��ֳѾl�ɶ�
            timeRemaining -= 1f;
        }

        // �˼ƭp�ɵ���
        Time.text = "time's up!";
        GameController.Instance.End();
        string v = "����:" + GameManager.Instance.score.ToString("00000");
        Content.text = v;
    }
  
    // Update is called once per frame
    void Update()
    {
        Score.text = "score\n" + GameManager.Instance.score.ToString("00000");
        
        //Time.text= "time\n" + GameManager.Instance.time.ToString("00000");
    }
}
