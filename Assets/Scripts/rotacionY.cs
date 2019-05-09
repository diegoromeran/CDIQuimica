using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionY : MonoBehaviour
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
        transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), speed*Time.deltaTime);
    }
}