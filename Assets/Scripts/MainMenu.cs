using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // carrega a cena do jogo
    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Principal");
    }

    // volta para o menu (botoes dentro do jogo)
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Para parar no editor
#endif
    }
}
