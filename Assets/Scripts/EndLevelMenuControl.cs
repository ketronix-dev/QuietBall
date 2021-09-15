using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelMenuControl : MonoBehaviour
{
    public int CurrentLevelIndex;
    public void Next()
    {
        SceneManager.LoadScene(CurrentLevelIndex + 1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
