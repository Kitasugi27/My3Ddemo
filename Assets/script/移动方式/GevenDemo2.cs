using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GevenDemo2 : MonoBehaviour
{
    public Transform[] target;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveTaget());
    }
    //协议：排队和并行两种操作
    // Update is called once per frame
   IEnumerator MoveTaget()
    {
        int index = 0;
        while (true)
        {
            index++;

            if (index >= target.Length)
            {
                index = 0;
            }   

            while (Vector3.Distance(transform.position, target[index].position) > 2f)
            {
                //移动到目标位置，速度为Time.deltaTime*5
                transform.position = Vector3.Lerp(transform.position, target[index].position, 0.05f);
                yield return null;
                //yield return null;暂停当前协程，等待下一帧继续执行
            }
            yield return null;

        }
    }
}