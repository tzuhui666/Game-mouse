using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public float totalTime = 120f;  // 倒數計時的總時間
    public Text Time;    // 用於顯示剩餘時間的UI Text物件
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
            // 更新顯示時間
            Time.text = "time\n" + timeRemaining.ToString("F0");

            // 等待一秒
            yield return new WaitForSeconds(1f);

            // 減少剩餘時間
            timeRemaining -= 1f;
        }

        // 倒數計時結束
        Time.text = "time's up!";
        GameController.Instance.End();
        string v = "分數:" + GameManager.Instance.score.ToString("00000");
        Content.text = v;
    }
  
    // Update is called once per frame
    void Update()
    {
        Score.text = "score\n" + GameManager.Instance.score.ToString("00000");
        
        //Time.text= "time\n" + GameManager.Instance.time.ToString("00000");
    }
}
