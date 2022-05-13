using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int x = 60;
    int y = 48;

    int result = 0;
    private void Awake()
    {
        Debug.Log("Awake 함수입니다.");
    }

    void Start()
    {
       // transform.position += new Vector3(transform.position.x,
       //     transform.position.y,
       //     transform.position.z);

        Debug.Log("Start합수 입니다?");
        for(int i = 1; i <= x && i <= y; i++)
        {
            if (x % i == 0 && y % i == 0)
            {
                result = i;
            }
        }
        Debug.Log(result);
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Updata 함수입니다.");
        }
        
    }
}
