using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    [SerializeField] private HeroStackController heroStackController;
    private RaycastHit hit;
    private bool isStack = false;
    private Vector3 direction=Vector3.back;
    // Start is called before the first frame update
    int elementCount=0;
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    void SetCubeRaycast()
    {                                                   //hit bizim çarptýðýmýz nesneyi tutuyor
        if(Physics.BoxCast(transform.position,transform.lossyScale/300,direction,out hit,transform.rotation,1f))
        {
            //çarpýþma anýnda tekrar tekrar stacklenmemesi için
            if (isStack == false)
            {
                isStack = true;
                heroStackController.IncreaseBlockStack(gameObject);
                SetDirection();
                //Debug.Log(hit.transform.name);
            }
            if (hit.transform.name == "Obstacle")
            {

                heroStackController.DecreaseBlock(gameObject);

            }
           

        }
    }



    void SetDirection()
    {
        //engeller için
        direction = Vector3.forward;

    }

}
