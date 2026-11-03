using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
   public void TestButtonClick()
   {
      //Debug.Log("Button Clicked!");

      //点击按钮切换到指定的场景
      Application.LoadLevel("小熊吃金币");
   }
}
