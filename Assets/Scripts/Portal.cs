using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public GameObject PanelIn;
    public GameObject PanelOut;
    private int scount;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PanelIn.SetActive(false);
            PanelOut.SetActive(true);
            Invoke("UpLevel",1);
        }
    }

    void UpLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
