using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public GameObject gameEnd;

    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start()
    {
        Init();
    }

    

    private void Init()
    {
        gameEnd.SetActive(false);
    }

    public void End()
    {
        gameEnd.SetActive(true);
    }



    public void OnBtnReplay()
    {
        SceneManager.LoadScene("Home");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.Instance.ResetScore();
    }


    public void OnBtnQuit()
    {

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif

            Application.Quit();
    }
}
