using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    [SerializeField]
    GameObject Boy;
    Vector3 aradakifark;
    
 
	// Use this for initialization
	void Start () {
        aradakifark = transform.position - Boy.transform.position;
 
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Boy.transform.position + aradakifark;
      
	}
}
