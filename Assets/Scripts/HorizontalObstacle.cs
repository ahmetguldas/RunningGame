using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public float y;
    public float speed;
    public string rotation;
    public float positionZ;
    public Rigidbody rb;



    // Update is called once per frame
    private void Start()
    {
         positionZ = transform.position.z;
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, (Mathf.PingPong(Time.time / 15, positionZ)));
        
        if (rotation == "right")
        {
            y += Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0,y,0);
        }
        else if(rotation == "left")
        {
            y -= Time.deltaTime * speed;
            transform.rotation = Quaternion.Euler(0,y,0);    
        }
        
    }
}
