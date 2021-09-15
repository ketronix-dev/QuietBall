using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private GameObject panel;
    // Update is called once per frame
    public void Close()
    {
        panel.SetActive(false);
        PlayerPrefs.SetFloat("Sen", slider.value*5);
    }
}
