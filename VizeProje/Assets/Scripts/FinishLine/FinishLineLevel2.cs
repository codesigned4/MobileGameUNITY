using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineLevel2 : MonoBehaviour
{
    public GameObject panel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MainCube" || collision.gameObject.name == "Cube")
        {
            Time.timeScale = 0.0f;
            panel.SetActive(true);
        }

    }

}
