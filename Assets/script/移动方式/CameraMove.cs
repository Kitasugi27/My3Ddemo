using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target; // 目标物体
    public float smoothSpeed = 0.125f; // 平滑移动速度
    public Vector3 StartPosition; // 摄像机初始位置
    void Start()
    {
        StartPosition=transform.position+target.position ;// 摄像机初始位置为目标物体位置加上摄像机当前位置
    }

    // Update is called once per frame
    void Update()
    {
        // 摄像机跟随目标物体
        void FixedUpdate()
        {
            Vector3 desiredPosition = target.position + StartPosition; // 计算目标位置
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, 
            desiredPosition, 
            smoothSpeed
            ); 
            // 平滑移动摄像机
            transform.LookAt(target); // 更新摄像机位置
        }
    }
}
