using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparicionAgua : MonoBehaviour
{
    GameObject agua;
    GameObject oxigeno;
    GameObject hidrogeno;
    // Start is called before the first frame update
    void Start()
    {
        hidrogeno = GameObject.Find("nucleoH");
        oxigeno = GameObject.Find("Oxigeno");
        agua = GameObject.Find("Agua");
        agua.SetActive(false);
        agua.SetActive(!agua.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(hidrogeno.transform.position, oxigeno.transform.position) < 10) {
            oxigeno.SetActive(false);
            hidrogeno.SetActive(false);
            agua.SetActive(true);
            agua.transform.position = (oxigeno.transform.position + hidrogeno.transform.position)/2;
        }
        if(Vector3.Distance(hidrogeno.transform.position, oxigeno.transform.position) > 15) {
            oxigeno.SetActive(true);
            hidrogeno.SetActive(true);
            agua.SetActive(false);
            agua.transform.position = (oxigeno.transform.position + hidrogeno.transform.position)/2;
        }
    }
}
