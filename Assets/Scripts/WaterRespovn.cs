using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterRespovn : MonoBehaviour
{
    [SerializeField] private GameObject PanelIn;
    [SerializeField] private GameObject PanelOut;
    public bool saved;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (saved == true)
            {
                Debug.Log("saved");
            }
            else if(saved == false)
            {
                PanelIn.SetActive(false);
                PanelOut.SetActive(true);
                Invoke("UpLevel", 1);
            }
        }
    }
    void UpLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
