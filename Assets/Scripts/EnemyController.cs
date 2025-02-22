using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{
    public int maxhealth = 5;
    int currenthealth;
    public int health { get { return currenthealth;} }
    public float enemyspeed = 1.0f;
    float timer;
    public int damage = -1;
    public float changetime = 1.0f;
    int direction = 1;
    public bool vertical = true;
    Rigidbody2D rigidbody2d;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changetime;
        currenthealth = maxhealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
        {
            direction = -direction;
            timer = changetime;
         
        }
    }

    void FixedUpdate()
    {
        Vector2 position = transform.position;
    
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * enemyspeed * direction;
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * enemyspeed * direction;
            animator.SetFloat("MoveY", 0);
            animator.SetFloat("MoveX", direction);
        }

        rigidbody2d.MovePosition(position);


    }

     void OnCollisionEnter2D(Collision2D collision)
    {
       //触发器获得是碰撞体，碰撞体进入获得的是碰撞所以要加gameObject来获取原本的碰撞体，再获取脚本组件
        AlanaController controller = collision.gameObject.GetComponent<AlanaController>();
        if(controller != null)
        {
            
            controller.ChangeHealth(damage);
        }
    }

}
