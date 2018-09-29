using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Button[] buttons;
    public Text scoreText;
    int Score;
    bool gameOver;
    // Use this for initialization
    public void Start()
    {
        gameOver = false;
        Score = 0;
        InvokeRepeating("scoreUpdate", 1.0f, 0.5f);

    }

    void scoreUpdate() {
        if (gameOver == false) { Score += 1;
        }
        
    }

    public void GameOver() {
        gameOver = true;
        foreach (Button button in buttons) {
            button.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    public void Update()
    {
        scoreText.text = "Score: " + Score.ToString();
        Debug.Log(Score.ToString());
    }

    public void menu()
    {
        Application.LoadLevel("MenuScene");
    }
    public void Play()
    {

         if (Time.timeScale == 0)
        {
            
            Time.timeScale = 1;
        }
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(false);
        }
        Application.LoadLevel("SampleScene");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(true);
            }
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(false);
            }
            Time.timeScale = 1;
        }

        


    }


    public void exit() {
        Application.Quit();
    }

    
}
