using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroInputController : MonoBehaviour
{

    private float horizontalValue;
    public float HorizontalValue
    {
        get { return horizontalValue; }
    }    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleHeroHorizontalInput();
    }
    
    private void HandleHeroHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            //sadece yatayda olan iþlemleri alýyoruz
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {   //sürüklemeyi býraktýðýmýzda ise 0 yapýyoruz
            horizontalValue = 0;
        }
    }

}
