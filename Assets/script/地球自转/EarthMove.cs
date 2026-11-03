using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMove : MonoBehaviour
{
    public GameObject earthGroup; // 地球组对象 
  
    public float Speed = 10f; // 自转速度

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 100); // 自转速度为10度每秒

        //根据不同星球，设置不同公转速度
        //获取自身的名称
        string planetName = gameObject.name;
        Debug.Log("当前星球名称：" + planetName);

        switch (planetName)
        {
            case "地球":
                Speed = 20f; // 地球公转速度为1度每秒
                break;
            case "水星":
                Speed = -20f; // 水星公转速度为-20度每秒
                break;
            case "木星":
                Speed = 50f; // 木星公转速度为50度每秒
                break;
            case "火星":
                Speed = -60f; // 火星公转速度为-60度每秒
                break;
            default:
                Speed = 10f; // 默认公转速度为1度每秒
                break;
        }

        earthGroup.transform.Rotate(Vector3.up * Time.deltaTime *Speed); // 公转速度为1度每秒    
    }
}
