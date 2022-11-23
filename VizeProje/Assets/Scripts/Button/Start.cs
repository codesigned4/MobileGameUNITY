using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public GameObject panel;

    public void StartGame()
    {
        Time.timeScale = 1.0f;

        panel.SetActive(false);
    }


}
