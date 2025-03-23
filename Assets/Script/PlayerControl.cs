using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public BaseMove BM;
    float speed = 0.05f;
    bool _keyDown = false;

    private void Start()
    {
        GetComponent<Rigidbody>();
        //获取用户组件
    }
    //在这里获取用户的输入
    void Update()
    {
        if (Input.GetKey(KeyCode.W))//上,z轴增加，y角度为0
        {
            Debug.Log("W");
            BM.Move(GetComponent<Transform>(), 0, 1, speed);

        }
        if (Input.GetKey(KeyCode.S))//下,z轴减少，y角度为180
        {
            Debug.Log("S");
            
            BM.Move(GetComponent<Transform>(), 0, -1, speed);
        }
        if (Input.GetKey(KeyCode.A))//左，x轴减少，y角度为-90
        {
            Debug.Log("A");
            BM.Move(GetComponent<Transform>(), -1, 0, speed);
        }
        if (Input.GetKey(KeyCode.D))//右，x轴增加，y角度为90
        {
            Debug.Log("D");
            BM.Move(GetComponent<Transform>(), 1, 0, speed);

        }

    }
}
