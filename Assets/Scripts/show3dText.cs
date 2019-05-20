using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show3dText : MonoBehaviour
{
    GameObject text;
    GameObject textMolecula;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.FindWithTag("texto3d");
        textMolecula= GameObject.FindWithTag("texto3dmolecula");
        text.SetActive(!text.activeInHierarchy);
        textMolecula.SetActive(!textMolecula.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) {
            text.SetActive(!text.activeInHierarchy);
            textMolecula.SetActive(!textMolecula.activeInHierarchy);
        }
    }
}
