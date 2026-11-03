using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterController : MonoBehaviour
{
    //创建子弹预制体的变量，用来绑定子弹
    public GameObject bulletPrefab;
    //创建子弹发射点的变量
    public Transform firePoint;
    //定义射击参数
    //子弹速度
    public float bulletSpeed = 20f;
    //子弹发射间隔
    public float fireRate = 0.5f;
    //定义一个间隔时间
    private float nextfireTimer = 0f;
    void Start()
    {
        //设置发射点的位置为当前物体的位置
        if (firePoint == null)
        {
            firePoint = this.transform;
        }
    }

        void Update()
    {
        //设置发射按钮,防止子弹连发
        if (Input.GetKey(KeyCode.Space)&& Time.time > nextfireTimer)
        {
            //执行发射函数
            Shoot();
        }
       
    }

void Shoot()
    {
        //设置下一次发射的时间
        nextfireTimer = Time.time + fireRate;
        //实例化子弹预制体
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        //获取子弹的脚本
        BulletController bulletController = bullet.GetComponent<BulletController>();

        if (bulletController != null)
        {
            //设置子弹的速度
           bulletController.speed = bulletSpeed;
        }
    }
}
