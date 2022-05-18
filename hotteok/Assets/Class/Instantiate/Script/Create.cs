using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        for(int i = -3; i < 6; i = i + 3)
        {
            Instantiate(obj, new Vector3(i, 0, 0), Quaternion.identity);
        }   
    }

    
    void Update()
    {
        
    }
}
