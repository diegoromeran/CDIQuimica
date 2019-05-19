using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparicionMoleculas : MonoBehaviour
{
    GameObject agua;
    GameObject oxigeno;
    GameObject hidrogeno;
    GameObject monoxido;
    GameObject carbono;
    GameObject metano;
    GameObject nitrogeno;
    GameObject amoniaco;
    GameObject sodio;
    GameObject cloro;
    GameObject sal;

    // Start is called before the first frame update
    void Start()
    {
        //Agua
        hidrogeno = GameObject.Find("nucleoH");
        oxigeno = GameObject.Find("Oxigeno");
        agua = GameObject.Find("Agua");
        agua.SetActive(false);
        agua.SetActive(!agua.activeInHierarchy);

        //Monoxido
        carbono = GameObject.Find("nucleoC");
        monoxido = GameObject.Find("Monoxido");
        monoxido.SetActive(false);
        monoxido.SetActive(!monoxido.activeInHierarchy);

        //Metano
        metano = GameObject.Find("Metano");
        metano.SetActive(false);
        metano.SetActive(!metano.activeInHierarchy);

        //Amoniaco
        nitrogeno = GameObject.Find("Nitrogeno");
        amoniaco = GameObject.Find("Amoniaco");
        amoniaco.SetActive(false);
        amoniaco.SetActive(!amoniaco.activeInHierarchy);

        //Sal
        sodio = GameObject.Find("nucleoNa");
        cloro = GameObject.Find("Cloro");
        sal = GameObject.Find("Sal");
        sal.SetActive(false);
        sal.SetActive(!sal.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        //Agua
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
        //Monoxido
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

        //Metano
        if(Vector3.Distance(carbono.transform.position, hidrogeno.transform.position) < 10) {
            hidrogeno.SetActive(false);
            carbono.SetActive(false);
            metano.SetActive(true);
            metano.transform.position = (hidrogeno.transform.position + carbono.transform.position)/2;
        }
        if(Vector3.Distance(carbono.transform.position, hidrogeno.transform.position) > 15) {
            hidrogeno.SetActive(true);
            carbono.SetActive(true);
            metano.SetActive(false);
            metano.transform.position = (hidrogeno.transform.position + carbono.transform.position)/2;
        }

        //Amoniaco
        if(Vector3.Distance(hidrogeno.transform.position, nitrogeno.transform.position) < 10) {
            hidrogeno.SetActive(false);
            nitrogeno.SetActive(false);
            amoniaco.SetActive(true);
            amoniaco.transform.position = (hidrogeno.transform.position + nitrogeno.transform.position)/2;
        }
        if(Vector3.Distance(hidrogeno.transform.position, nitrogeno.transform.position) > 15) {
            hidrogeno.SetActive(true);
            nitrogeno.SetActive(true);
            amoniaco.SetActive(false);
            amoniaco.transform.position = (hidrogeno.transform.position + nitrogeno.transform.position)/2;
        }

        //Sal
        if(Vector3.Distance(sodio.transform.position, cloro.transform.position) < 10) {
            sodio.SetActive(false);
            cloro.SetActive(false);
            sal.SetActive(true);
            sal.transform.position = (sodio.transform.position + cloro.transform.position)/2;
        }
        if(Vector3.Distance(sodio.transform.position, cloro.transform.position) > 15) {
            sodio.SetActive(true);
            cloro.SetActive(true);
            sal.SetActive(false);
            sal.transform.position = (sodio.transform.position + cloro.transform.position)/2;
        }
    }
}
