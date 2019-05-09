using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionX : MonoBehaviour
{  
    float speed;
    float radio;

    // Start is called before the first frame update
    void Start()
    {
        speed = 250;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.parent.position, new Vector3(1, 0, 0), speed*Time.deltaTime);
    }
}