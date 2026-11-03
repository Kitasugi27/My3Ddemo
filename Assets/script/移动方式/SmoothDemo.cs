using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDemo : MonoBehaviour
{
    //定义目标位置的Transform组件，作为物体移动的目标位置
    //组件需要创建一个空物体，不能有形状，只提供坐标点
    public Transform target;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update 
    void Update()
    {
        //Vector3.SmoothDamp(起点坐标，终点坐标，速度变量，衰减系数)中的参数说明：
        //第一个参数：当前物体的位置
        //第二个参数：目标位置
        //第三个参数：当前速度
        //第四个参数：平滑时间，数值越小，移动越快
        //第五个参数：最大速度，数值越大，移动越快
        transform.position = Vector3.SmoothDamp(
            transform.position, 
            target.position, 
            ref velocity, 
            1f
        );
    }
}
