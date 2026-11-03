using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    
    //设置子弹的飞行速度
    public float speed = 10f;
    //设置子弹存活时间,防止内存泄露
    public float lifetime = 3f;

    void Start()
    {
        //在子弹创建时启动销毁协程
        //gameObject代表当前绑定的物体本身
        Destroy(gameObject, lifetime);
    }

    
    void Update()
    {
        //让子弹沿着自身的正方向移动
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    //检测子弹是否撞到墙壁
    private void OnCollisionEnter(Collision collision)
    {
        //如果子弹撞到墙壁,销毁子弹
        if (collision.gameObject.name=="wall")
        {
            Debug.Log("子弹撞到墙壁");
            Destroy(gameObject);
        }
    }
}
