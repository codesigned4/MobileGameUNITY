using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congrats : MonoBehaviour
{
    public AudioSource congrats;
    public GameObject panel;


    private void Start()
    {
        
        congrats.Play();
       
    }


}
