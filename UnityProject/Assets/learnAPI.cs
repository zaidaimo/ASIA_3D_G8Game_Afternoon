using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnAPI : MonoBehaviour
{
    private void Start()
    {
        print(Random.value);
        print(Mathf.PI);
        


        print(Mathf.Abs(-99));
        print(Random.Range(50, 100));

        Debug.Log("檢查");
        Debug.LogWarning("警告");
        Debug.LogError("危險");
    }

    private void Update()
    {
        print(Time.time);

        print(Input.GetAxis("Vertical"));
        print(Input.GetAxis("Horizontal"));


        print(Input.mousePosition);
        print(Input.GetKeyDown("space"));
    }
   
   
        
  
}
