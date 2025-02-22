using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialog : MonoBehaviour
{
    public float dialogtime = 1f;
    float timer;
    public GameObject dialogbox;
    public TextMeshProUGUI textbox;
    // Start is called before the first frame update
    void Start()
    {
        dialogbox .SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if(timer < 0 )
        {
            dialogbox.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayText(); // ²âÊÔ
        }
    }

    public void DisplayText()
    {
        timer = dialogtime;
        dialogbox.SetActive(true);
        textbox.text = "aaaa";
    }

}
