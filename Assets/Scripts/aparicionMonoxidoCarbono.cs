using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparicionMonoxidoCarbono : MonoBehaviour
{
    GameObject monoxido;
    GameObject oxigeno;
    GameObject carbono;
    // Start is called before the first frame update
    void Start()
    {
        carbono = GameObject.Find("nucleoC");
        oxigeno = GameObject.Find("Oxigeno");
        monoxido = GameObject.Find("Monoxido");
        monoxido.SetActive(false);
        monoxido.SetActive(!monoxido.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(carbono.transform.position, oxigeno.transform.position) < 10) {
            oxigeno.SetActive(false);
            carbono.SetActive(false);
            monoxido.SetActive(true);
            monoxido.transform.position = (oxigeno.transform.position + carbono.transform.position)/2;
        }
        if(Vector3.Distance(carbono.transform.position, oxigeno.transform.position) > 15) {
            oxigeno.SetActive(true);
            carbono.SetActive(true);
            monoxido.SetActive(false);
            monoxido.transform.position = (oxigeno.transform.position + carbono.transform.position)/2;
        }
    }
}
