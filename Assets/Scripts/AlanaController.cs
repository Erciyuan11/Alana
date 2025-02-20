using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class AlanaController : MonoBehaviour
{
    public int maxhealth = 5;
    public float speed = 3.0f;
    //属性使用的规则是get，因此可以public只读
    public int health { get { return currenthealth; } }
    int currenthealth;
    bool isInvincible;
    float invincibleTimer;
    public float timeInvincible = 2.0f;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        //初始获取刚体组件
        rigidbody2d = GetComponent<Rigidbody2D>();
        currenthealth = maxhealth;
        isInvincible = false;

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //每帧减去每帧的时长，最后就是每2秒让布尔变负
        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
                isInvincible = false;
        }

    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.y = position.y + vertical * speed * Time.deltaTime;
        position.x = position.x + horizontal * speed * Time.deltaTime;
        //rigidbody2d.position = position;
        rigidbody2d.MovePosition(position);

    }
    public void ChangeHealth(int amount)
    {
        if(amount <0)
        {
            //如果布尔是负，那么就扣血，不是无敌的
            if(isInvincible)
            {
                return;
            }
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        //函数用于限制范围，不小于第二个，不大于第3个
        currenthealth = Mathf.Clamp(currenthealth + amount, 0, maxhealth);
        Debug.Log(currenthealth + "/" + maxhealth);
    }
 }

