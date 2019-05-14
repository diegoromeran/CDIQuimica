using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show3dText : MonoBehaviour
{
    GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindWithTag("texto3d");
        text.SetActive(!text.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I)) {
            text.SetActive(!text.activeInHierarchy);
        }
    }
}
