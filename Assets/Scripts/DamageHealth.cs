using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHealth : MonoBehaviour
{
    // Start is called before the first frame update
     void OnTriggerStay2D(Collider2D collision)
    {
        AlanaController controller = collision.GetComponent<AlanaController>();
        if (controller != null )
        {
            if(controller.health> 0)
            {
                controller.ChangeHealth(-1);
                Debug.Log("现在的血量是" + controller.health);
            }
        }
    }

}
