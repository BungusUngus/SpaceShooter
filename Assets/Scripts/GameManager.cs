using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;
    public Text scoreText;
    float timer;
    public static GameManager gm;
    public bool playing;
    public float score;
    public GameObject Pause;
    public bool paused;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gm = this;
        timer = 0;
        playing = true;
      
    }
    private void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString();
            scoreText.text = score.ToString();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                paused = !paused;
            }
        }
        else
        {
            Invoke("ChangeScene", 5f);
        }

        if (paused)
        {
            Time.timeScale = 0;
        }

        else
        {
            Time.timeScale = 1;
        }

        Pause.SetActive(paused);
        gameOver.SetActive(!playing);

    }
}
