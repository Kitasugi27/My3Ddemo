using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookBear : MonoBehaviour
{
    public Transform Bear;
    public Vector3 offset;//定义一个摄影机与目标对象的偏移量

    void Update()
    {
        offset = new Vector3(0f, 1.36f, -4.06f);//设置偏移量为(0,5,-10)
        // //transform.position = target.position + offset;//摄影机的位置等于目标对象的位置加上偏移量
        // //transform.LookAt(target);//让摄影机始终看向目标对象
    }

    void LateUpdate()
    {
        transform.position = Bear.position + offset;//摄影机的位置等于目标对象的位置加上偏移量

    }
}
