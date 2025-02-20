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
    bool isUp;
    public float maxhight = 0.5f;
    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        isUp = true;
        currenthealth = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector2 position = transform.position;
        Changedirection(isUp,position.y);
        if (isUp )
        {
            position.y = position.y + enemyspeed * Time.deltaTime;
        }
        else
        {
            position.y = position.y - enemyspeed * Time.deltaTime;
        }
        
        rigidbody2d.MovePosition(position);

        
    }

   void Changedirection (bool Updown,float positiony)
    {
        if (positiony> maxhight)
        {
            isUp = false;
        }
        if (positiony<-1*maxhight)
        {
            isUp = true;
        }

    }
}
