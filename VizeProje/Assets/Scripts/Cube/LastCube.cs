using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastCube : MonoBehaviour
{

    public HeroStackController heroStackController;
    public AudioSource congrats;


    public void Start()
    {
        congrats.Play();
    }
    void Update()
    {

        gameObject.transform.position = heroStackController.GetElement().transform.position;
        
    }

}
