using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterRespovn : MonoBehaviour
{
    [SerializeField] private ScreenFade fade;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
                fade.fadeOut();
                Invoke("UpLevel", 1);
        }
    }
    void UpLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
