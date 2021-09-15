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
    public void NextsLevel(GameObject panelout)
    {
	    panelout.SetActive(true);
	    Invoke("UpLevel",1);
    }
	void UpLevel()
    {
	    SceneManager.LoadScene(1);
    }
	public void Quit()
	{
		Invoke("QuitScreen",1);
	}
	void QuitScreen()
	{
		Application.Quit();
	}
}
