using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefabs : MonoBehaviour
{
    //创建一个预制体对象
    public GameObject prefab;
    void Start()
    {   
        // //动态创建物体时，坐标和旋转的默认值是0，0，0
        // Instantiate(prefab, transform.position, transform.rotation);//创建预制体对象(目标，坐标位置，旋转方向)，将自身作为父物体
        
        // //设置动态物体的旋转方向
        // Quaternion rotation= Quaternion.Euler(new Vector3(0, 0, 0), 0);//设置旋转方向
        // //rotation = Quaternion.identity;//表示用预制体自身的旋转方向
        // Instantiate(prefab, new Vector3(0, 0, 0), rotation);//创建预制体对象(目标，坐标位置，旋转方向)，将自身作为父物体
        // //动态创建物体无法指定大小，需要定义一个变量，把动态物体赋给变量，然后通过变量去改变大小
        GameObject newobj = Instantiate(prefab, transform.position, transform.rotation);//创建预制体对象(目标，坐标位置，旋转方向)，将自身作为父物体
        //通过对象变量来调整动态物体的大小
        newobj.transform.localScale = new Vector3(2, 2, 2);//设置动态物体的大小

    }

    
    void Update()
    {
        
    }
}
