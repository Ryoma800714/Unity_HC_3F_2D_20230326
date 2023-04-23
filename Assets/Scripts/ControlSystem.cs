﻿using UnityEngine;

public class ControlSystem : MonoBehaviour
{
  [Header("移動速度")]
  [Range(0.5f, 99.9f)]
  public float movespeed = 3.5f;

  [Header("剛體")]
   public Rigidbody2D rig;

    [Header("動畫控制器")]
    public Animator ani;

    [Header("跑步參數")]
    public string parRun = "關閉跑步";
    private void Awake()
    {
       // print("隨便拉");

       // print("1+2");

       // print($"{1 + 2}");
            
    }
    private void Start()
    {
       // print("<color=blue>"開始"</color>");
        
    }
    private void Update()
    {
        // print("<color=black>"更新開始"</color>");

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rig.velocity = new Vector3(h, v, 0)
            * movespeed;
    }

}
