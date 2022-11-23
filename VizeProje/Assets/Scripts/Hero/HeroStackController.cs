using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    public GameObject lastBlockObject;
    public GameObject panel;
    public AudioSource collect;

    int count = 1;

    void Start()
    {
        UpdateLastBlockObject();
    }

    public void IncreaseBlockStack(GameObject _gameObject)
    {
        count += 1;
        collect.Play();
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 2f, lastBlockObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);
        UpdateLastBlockObject();
    }


    public void DecreaseBlock(GameObject _gameObject) {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObject();
    }

    private void UpdateLastBlockObject()
    {
        try
        {
            lastBlockObject = blockList[blockList.Count - 1];
            count = blockList.Count;
           
        }
        catch
        {
            panel.SetActive(true);
            Time.timeScale = 0.0f;
            //Debug.Log("OYUN BÝTTÝ");

        }
    }
 
    public GameObject GetElement()
    {
        return lastBlockObject;
    }
    public int GetElementCount()
    {
        return count;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.transform.position.y <= collision.transform.position.y && collision.transform.name=="Obstacle")
        {
            panel.SetActive(true);
            Time.timeScale = 0.0f;
            //Debug.Log("Öldün çýk");
        }
    }
}


