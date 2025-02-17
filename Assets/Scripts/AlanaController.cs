using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlanaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        if (horizontal != 0)
        {
            Debug.Log(horizontal);
        }
        if (Vertical != 0)
        {
            Debug.Log(Vertical);
        }
        Vector2 alanapos = transform.position;
        //速度乘以帧的时长，现在速度和帧数无关
        alanapos.x = alanapos.x + 2f*horizontal*Time.deltaTime;
        alanapos.y = alanapos.y + 2f * Vertical * Time.deltaTime;
        transform.position = alanapos;
    }
}
