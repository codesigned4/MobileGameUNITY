using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public HeroStackController heroStackController;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="MainCube" || other.name == "Cube")
        {
            heroStackController.DecreaseBlock(other.gameObject);
            other.gameObject.SetActive(false);
        }
    }
}
