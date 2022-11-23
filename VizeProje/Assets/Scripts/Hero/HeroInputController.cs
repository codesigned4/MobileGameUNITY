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
            //sadece yatayda olan i�lemleri al�yoruz
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else
        {   //s�r�klemeyi b�rakt���m�zda ise 0 yap�yoruz
            horizontalValue = 0;
        }
    }

}
