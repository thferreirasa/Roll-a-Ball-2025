using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60f;
    public TMP_Text timerText;
    public GameObject loseText;
    public Color normalColor = Color.white;
    public Color warningColor = Color.red;
    public float warningTime = 10f;
    public GameObject retryButton;

    private bool isGameOver = false;

    // Update is called once per frame
    private void Start()
    {
        loseText.SetActive(false);
    }
    void Update()
    {
        if (isGameOver)
        {
            return;
        }

        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            timeLeft = 0;
            isGameOver = true;
            if (loseText != null) loseText.SetActive(true);
            Time.timeScale = 0f; // pausa o jogo
            loseText.SetActive(true);
        }

        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.Ceil(timeLeft).ToString();

            // Muda a cor se estiver perto do fim
            if (timeLeft <= warningTime)
            {
                // Faz piscar entre normal e vermelho
                float t = Mathf.PingPong(Time.time * 5f, 1f); // 5f = velocidade do piscar
                timerText.color = Color.Lerp(normalColor, warningColor, t);
            }
            else
            {
                timerText.color = normalColor;
            }
        }
    }
}
