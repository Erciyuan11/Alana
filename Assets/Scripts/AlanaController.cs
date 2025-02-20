using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class AlanaController : MonoBehaviour
{
    public int maxhealth = 5;
    public float speed = 3.0f;
    //����ʹ�õĹ�����get����˿���publicֻ��
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
        //��ʼ��ȡ�������
        rigidbody2d = GetComponent<Rigidbody2D>();
        currenthealth = maxhealth;
        isInvincible = false;

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //ÿ֡��ȥÿ֡��ʱ����������ÿ2���ò����为
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
            //��������Ǹ�����ô�Ϳ�Ѫ�������޵е�
            if(isInvincible)
            {
                return;
            }
            isInvincible = true;
            invincibleTimer = timeInvincible;
        }
        //�����������Ʒ�Χ����С�ڵڶ����������ڵ�3��
        currenthealth = Mathf.Clamp(currenthealth + amount, 0, maxhealth);
        Debug.Log(currenthealth + "/" + maxhealth);
    }
 }

