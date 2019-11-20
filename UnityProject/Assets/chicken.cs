using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{

    [Header("移動速度")]
    public int speed = 10;
    [Header("旋轉速度")]
    public float turn = 20.5f;
    [Header("物件名稱")]
    public string _name = "G8";
    public bool mission;

    public void G8(float speed, int scream, int pickup, int check, string direction = "前方", string mission = "關閉")
    {
        print("跑步速度:" + speed);
        print("亂叫次數:" + scream);
        print("撿東西次數:" + pickup);
        print("旋轉方向:" + direction);
        print("檢視任務:" + mission);

    }

    public void Start()
    {
        G8(10.5f, 5, 2, mission: "開啟");
    }

   
    // Update is called once per frame
    void Update()
    {
     
    }
}
