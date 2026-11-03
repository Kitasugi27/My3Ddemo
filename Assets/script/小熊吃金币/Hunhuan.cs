using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunHuan : MonoBehaviour
{
    // 定义一个高度变量
    public int heights;

    // 定义一个播放魂环动画的布尔变量
    public bool playHuan = false;


    void Start()
    {
        //在局部坐标系下, 将物体的位置设置为Vector3(0, 10, 0, Space.Self);
        transform.Translate(Vector3.up * 2f, Space.Self);
        // 不渲染自己
        GetComponent<Renderer>().enabled = false;

        //提取自己名称中的数字, 每个魂环名称后面都要有_数字
        string[] strs = gameObject.name.Split('_');
        heights = int.Parse(strs[1]);
        Debug.Log(heights);

    }

    // Update is called once per frame
    void Update()
    {
        if (playHuan)
        {
            //判断魂环的排序, 奇偶数的旋转方向不同。
            if (heights % 2 == 0)
            {
                //让魂环保持自转效果, 顺时针旋转
                transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.Self);
            }
            else
            {
                //让魂环保持自转效果, 逆时针旋转。
                transform.Rotate(Vector3.down * 50 * Time.deltaTime, Space.Self);
            }

            // 魂环发光, 五环以内黑黄色, 五环以外红黄色。
            if (heights <= 3)
            {
                // 获取EmissionColor的值, 每0.5秒变换一次颜色, 颜色从黑色到黄色。
                Color emissionColor = GetComponent<Renderer>().material.color;
                emissionColor = Color.Lerp(Color.black, Color.yellow, Mathf.Sin(Time.time * 2f));
                GetComponent<Renderer>().material.color = emissionColor;
                GetComponent<Renderer>().material.SetColor("_EmissionColor", emissionColor);
            }
            else
            {
                // 获取EmissionColor的值, 每0.5秒变换一次颜色, 颜色从粉色到红色。
                Color emissionColor = GetComponent<Renderer>().material.color;
                emissionColor = Color.Lerp(Color.yellow, Color.red, Mathf.Sin(Time.time * 2f));
                GetComponent<Renderer>().material.color = emissionColor;
                GetComponent<Renderer>().material.SetColor("_EmissionColor", emissionColor);
            }

            //下落直到父物体的高度减去魂环高度的一半以下, 每个魂环最后的位置根据自己的数字来确定;
            if (transform.position.y >= transform.parent.position.y + 0.1f * heights)
            {
                // (5f/heights) 使每个魂环的下落速度不同, 越高的魂环下落速度越慢。
                transform.Translate(Vector3.down * (3f / heights) * Time.deltaTime, Space.Self);
                // Destroy(gameObject);
            }
        }

        // 按Q键播放魂环动画。
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 渲染自己
            GetComponent<Renderer>().enabled = true;

            //在局部坐标系下, 将物体的位置设置为Vector3(0, 10, 0,Space.Self);
            transform.Translate(Vector3.up * 2f, Space.Self);

            // 播放魂环动画
            playHuan = true;
        }
    }
}
