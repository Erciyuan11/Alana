using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlanaController : MonoBehaviour
{
    public int maxhealth = 5;
    public float speed = 3.0f;
    int currenthealth;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currenthealth = 1;

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
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
        currenthealth = Mathf.Clamp(currenthealth + amount, 0, maxhealth);
        Debug.Log(currenthealth + "/" + maxhealth);
    }
 }

