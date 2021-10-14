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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadGame()
    {
        PlayerPrefs.SetInt("Saved", SceneManager.GetActiveScene().buildIndex);
    }
    public void SaveGame()
    {
        if(PlayerPrefs.GetInt("Saved") != 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Saved"));
        }
    }
    public void MainMenu(int scene_count)
    {
        SceneManager.LoadScene(scene_count);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
