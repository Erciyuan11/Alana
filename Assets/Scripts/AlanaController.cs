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
        Vector2 alanapos = transform.position;
        alanapos.x = alanapos.x + 0.1f;
        transform.position = alanapos;
    }
}
