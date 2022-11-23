using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="MainCube"|| collision.gameObject.name == "Cube")
        {
            SceneManager.LoadScene("Scenes/Level2");
            Time.timeScale = 1.0f;

        }

    }

}
