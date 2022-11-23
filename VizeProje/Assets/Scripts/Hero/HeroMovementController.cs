using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMovementController : MonoBehaviour
{
    [SerializeField] private HeroInputController heroInputController;
    [SerializeField] private float forwardMovementSpeed;
    [SerializeField] private float horizontalMovementSpeed;
    [SerializeField] private float horizontalLimitValue;

    private float newPositionX;

    public void Start()
    {
        //level2 nin açýldýðý gibi baþlamasý için
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }

    void FixedUpdate()
    {
        SetHeroForwardMovement();
        SetHeroHorizontalMovement(); 
    }
    private void SetHeroForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMovementSpeed * Time.fixedDeltaTime);
    }

    private void SetHeroHorizontalMovement()
    {
        newPositionX = transform.position.x+heroInputController.HorizontalValue*horizontalMovementSpeed*Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimitValue, horizontalLimitValue);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
