 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;
    public Text scoreText;
    float timer;
    public static GameManager gm;
    public bool playing;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gm = this;
        timer = 0;
        playing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playing)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString();
            scoreText.text = score.ToString();
        }
    }
}
