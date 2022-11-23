using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public HeroStackController heroStackController;
    public Image health_bar;

    float health = 100.0f;
    float current_health = 0.01f;

    // Update is called once per frame
    void Update()
    {
        current_health = (heroStackController.GetElementCount()) / health;
        health_bar.fillAmount = current_health;
    }
}
