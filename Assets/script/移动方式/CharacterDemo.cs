using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDemo : MonoBehaviour
{
    //角色移动速度
    public float speed = 6f;
    //重力
    public float Gravity = -9.81f;
    //跳跃高度
    public float jumpHeight = 5f;

     //获取角色控制器组件
        public CharacterController controller ;
        private Vector3 velocity;
        //判断是否在地面上
        private bool isGrounded;
    void Start()
    {
       controller= GetComponent<CharacterController>();
    }

    //
    void Update()
    {
        //判断物体是否在地面上
        isGrounded = controller.isGrounded;
        //如果在地面上并且y轴速度小于0，则将y轴速度设置为-2f
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        //获取移动方向
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * Gravity);
        }
        //计算y轴下落速度
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
