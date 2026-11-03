using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearToCoin : MonoBehaviour
{ 
    //设置修改背景音乐
     //绑定场景中的BGM组件
     public AudioSource Audios;
    public AudioSource BGM;
    
    //定义音乐变量
    public AudioClip clips;

    
    //定义音乐变量
    public AudioClip BGM_clips;
   

    //当碰撞体的中IS Trigger勾选之后，检测到碰撞需要用OnTriggerEnter(Collider other)
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("碰撞了"+other.gameObject.name);//打印碰撞的物体名称

        //如果碰到物体的Tag是"Item"，就销毁Coin
        if (other.gameObject.tag=="Item")
        {
            // 吃金币后播放音效
            Audios.PlayOneShot(clips);//播放音效
            Destroy(other.gameObject);

            //修改背景音乐
            if(BGM.clip.name!="Bgm_JieMian")
            {
                BGM.clip = BGM_clips;
                BGM.Play();
            }
        }
    }
}
