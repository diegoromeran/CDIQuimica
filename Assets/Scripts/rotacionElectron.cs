using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacionElectron : MonoBehaviour
{  
    float timeCounter=0;
    float speed;
    float posicionX;
    float posicionY;
    float posicionZ;
    float radio;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        posicionX = gameObject.transform.position.x;
        posicionY = gameObject.transform.position.y;
        posicionZ = gameObject.transform.position.z;
        radio = 2;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        float x = Mathf.Cos(timeCounter)*radio;
        float y = Mathf.Sin(timeCounter)*radio;
        float z = 0;
        transform.position= new Vector3 (posicionX+x, posicionY+y,posicionZ+z);
    }
}