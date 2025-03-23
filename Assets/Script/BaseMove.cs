using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMove : MonoBehaviour
{
    //移动逻辑,方向以及速度
    
    public void Move(Transform role,float Up_Down, float R_L, float speed)//角色，上下方向，左右方向，速度
    {
        role.position = new Vector3(role.position.x+Up_Down * speed, role.position.y, role.position.z+R_L * speed);//左右，上下，前后
        role.rotation = Quaternion.Euler(0, Mathf.Atan2(Up_Down, R_L) * Mathf.Rad2Deg, 0);//角度
        //角度计算，反正切函数，弧度转角度
    }
}
