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

    public void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Para parar no editor
#endif
    }
}
