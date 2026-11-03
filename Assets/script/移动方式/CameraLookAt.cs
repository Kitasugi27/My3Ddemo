using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;//定义一个摄影机与目标对象的偏移量

    void Update()
    {
        offset = new Vector3(0f, 0.86f, -1.16f);//设置偏移量为(0,5,-10)
        //transform.position = target.position + offset;//摄影机的位置等于目标对象的位置加上偏移量
        //transform.LookAt(target);//让摄影机始终看向目标对象
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;//摄影机的位置等于目标对象的位置加上偏移量
        transform.LookAt(target);//让摄影机始终看向目标对象
    }
}
