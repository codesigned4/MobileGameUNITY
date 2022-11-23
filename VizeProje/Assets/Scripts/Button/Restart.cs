using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void Btn_Restart()
    {
        SceneManager.LoadScene("Scenes/Level1");
        Time.timeScale = 1.0f;

    }


}
