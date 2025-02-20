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
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changetime;
        currenthealth = maxhealth;
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
        position.x = position.x + enemyspeed *direction * Time.deltaTime;
        position.y = position.y + enemyspeed*direction * Time.deltaTime;
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
