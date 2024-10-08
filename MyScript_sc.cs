using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript_sc : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 2.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dikey = Input.GetAxis("Vertical");
        float yatay = Input.GetAxis("Horizontal");
        transform.position += Vector3.up * dikey * speed ;
        transform.position += Vector3.right * yatay * speed; 
    }
}
