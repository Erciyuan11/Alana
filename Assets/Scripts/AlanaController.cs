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
        alanapos.x = alanapos.x + 0.1f*horizontal;
        alanapos.y = alanapos.y + 0.1f * Vertical;
        transform.position = alanapos;
    }
}
