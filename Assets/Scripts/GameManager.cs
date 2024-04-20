using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] mouse;
    public static GameManager Instance;
    public float time;
    public int score;
    public int max = 1;

    private float timer = 0;

    //public float interval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Load();
        
    }
    public void Load()
    {
        SceneManager.LoadScene($"SampleScene");
    }
    private void CreateCard(int index)
    {
        float x = Random.Range(0, 7.6f);
        float y = Random.Range(0, 3);
        Instantiate(mouse[index], new Vector3(x, y, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timer += Time.deltaTime;
        if (timer > 0.7f)
        {
            CreateCard(Random.Range(0, mouse.Length));
            if (transform.position.x > 10 || transform.position.x < -10)
            {
                Destroy(this.gameObject);
            }
            timer = 0;
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void DelayReset(float delay)
    {
        Invoke(nameof(Load), delay);
    }

    public void AddScore()
    {
        score += max;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
