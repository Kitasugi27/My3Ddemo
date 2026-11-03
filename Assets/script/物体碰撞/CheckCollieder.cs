using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollieder : MonoBehaviour
{
    //当物体与其他物体发生碰撞时，触发该函数
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("碰撞了"+collision.gameObject.name);//打印碰撞的物体名称
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("持续碰撞中"+collision.gameObject.name);//打印碰撞的物体名称
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("碰撞结束"+collision.gameObject.name);//打印碰撞的物体名称
    }
}
