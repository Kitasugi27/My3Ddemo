using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GevenDemo : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveTaget());
    }
    //协议：排队和并行两种操作
    // Update is called once per frame
   IEnumerator MoveTaget()
    {
        //排队操作
        //transform.position = target.position;
        //并行操作
        //while循环表示判断当目标的位置和当前物体的位置的距离大于0.1时，继续执行移动操作
        while (Vector3.Distance(transform.position, target.position) > 0.1f)
        {
            //移动到目标位置，速度为Time.deltaTime*5
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * 5);
            //yield return null;暂停当前协程，等待下一帧继续执行
            yield return null;
        }
    }
}