using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holamundo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objects;
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Sword");
        foreach (GameObject obj in objects) Debug.Log(obj);
        objects = GameObject.FindGameObjectsWithTag("Tree");
        foreach (GameObject obj in objects) Debug.Log(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
