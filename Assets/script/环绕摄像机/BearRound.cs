using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearRound : MonoBehaviour
{
    // 定义一个监测目标
    public Transform target;
    // 定义一个主摄像机变量
    public Camera mainCamera;
    // 定义一个副摄像机变量
    public Camera subCamera;


    void Start()
    {
        // 主摄像机显示, 副摄像机隐藏
        mainCamera.enabled = true;
        subCamera.enabled = false;
    }

    void Update()
    {
        // 按空格键, 5秒内自转360度。
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 副摄像机显示, 主摄像机隐藏
            subCamera.enabled = true;
            mainCamera.enabled = false;
            StartCoroutine(RotateAroundTarget());
        }
    }

    IEnumerator RotateAroundTarget()
    {
        float duration = 5f; // 持续时间为5秒
        float elapsedTime = 0f; // 已经过的时间
        float angle = 0f; // 当前旋转角度

        while (elapsedTime < duration)
        {
            // 计算每帧的旋转角度
            float deltaAngle = (360f / duration) * Time.deltaTime;
            angle += deltaAngle;

            // 绕目标点旋转
            transform.RotateAround(target.position, Vector3.up, deltaAngle);

            elapsedTime += Time.deltaTime;
            yield return null; // 等待下一帧
        }

        // 确保最终旋转角度为360度
        transform.RotateAround(target.position, Vector3.up, 360f - angle);

        // 副摄像机隐藏, 主摄像机显示
        yield return new WaitForSeconds(2f);
        subCamera.enabled = false;
        mainCamera.enabled = true;
    }
}
