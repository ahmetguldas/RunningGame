using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        transform.Translate(Vector3.forward * 0.3f * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector3.right * 1 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 1 * Time.deltaTime);
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, (float)-0.1, (float)0.5));
    }

    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    }

}
