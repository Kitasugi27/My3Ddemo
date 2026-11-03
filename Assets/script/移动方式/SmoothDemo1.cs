using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDemo1 : MonoBehaviour
{
    //定义目标位置的Transform组件，作为物体移动的目标位置
    //组件需要创建一个空物体，不能有形状，只提供坐标点
    public Transform[] target;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update 
    void Update()
    {
        int index=0;
        while (true)
        {
            transform.position = Vector3.SmoothDamp(
            transform.position, 
            target[index].position, 
            ref velocity, 
            1f
        );

        index++;
        if (index >= target.Length)
        {
            index = 0;
        }
       
    }
}
}
