using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorScript : MonoBehaviour
{
    public float y;
    public float speed;
    public string rotation;


    // Update is called once per frame
    void Update()
    {
        if (rotation == "right")
        {
            y += Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }
        else if (rotation == "left")
        {
            y -= Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0, y, 0);
        }

    }
}
