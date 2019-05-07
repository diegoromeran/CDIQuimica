using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electronMov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f,22f,0f));
        transform.Translate(Vector3.forward);
    }
}
