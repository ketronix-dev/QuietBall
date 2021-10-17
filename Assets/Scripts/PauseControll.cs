using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControll : MonoBehaviour
{
    [SerializeField] private GameObject PanelPause;
    public void ShowPause()
    {
        PanelPause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePause()
    {
        PanelPause.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadGame()
    {
        PlayerPrefs.SetInt("Saved", SceneManager.GetActiveScene().buildIndex);
        PanelPause.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void SaveGame()
    {
        if(PlayerPrefs.GetInt("Saved") != 0)
        {
            Time.timeScale = 1.0f;
            SceneManager.LoadScene(PlayerPrefs.GetInt("Saved"));
        }
    }
    public void MainMenu(int scene_count)
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(scene_count);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
