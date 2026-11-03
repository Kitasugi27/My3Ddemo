using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearMoveDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveY)*Time.deltaTime*10;

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0.0f, -2.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0.0f, 2.0f, 0.0f));
        }
        //让物体沿着自身的坐标轴移动
        //space.Self表示沿着自身坐标轴移动，space.World表示沿着世界坐标轴移动
        transform.Translate(movement,Space.Self);
    }

   
}
