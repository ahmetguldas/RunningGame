using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public float z;
    public float speed;
    public string rotation;
    

    // Update is called once per frame
    void Update()
    {
        if (rotation == "right")
        {
            z += Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0,90,z);
        }
        else if(rotation == "left")
        {
            z -= Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0,90,z);    
        }
        
    }
}
