using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GevenDemo3 : MonoBehaviour
{
    public Transform[] target;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveToTaget());
    }
    //协议：排队和并行两种操作
    // Update is called once per frame
   IEnumerator MoveToTaget()
    {
        for (int i = 0; i < target.Length; i++)
        {
            while (Vector3.Distance(transform.position, target[i].position) >2f)
            {
                //移动到目标位置，速度为Time.deltaTime*5
                transform.position = Vector3.MoveTowards(transform.position, target[i].position, 0.1f);
                //yield return null;暂停当前协程，等待下一帧继续执行
                yield return null;
             }
        }
    }
}