using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuContr : MonoBehaviour
{
	public void Autors(GameObject panel)
	{
		panel.SetActive(true);
	}
    public void NextsLevel(ScreenFade fade)
    {
	    fade.fadeOut();
	    Invoke("UpLevel",1);
    }
	void UpLevel()
    {
	    SceneManager.LoadScene(1);
    }
	public void Quit(ScreenFade fade)
	{
		fade.fadeOut();
		Invoke("QuitScreen",1);
	}
	void QuitScreen()
	{
		Application.Quit();
	}
}
