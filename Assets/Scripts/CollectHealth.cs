using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        AlanaController controller = other.GetComponent<AlanaController>();
        if (controller != null)
            Debug.Log(controller.health + "/" + controller.maxhealth);
        {
            if(controller.health < controller.maxhealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    }
}
