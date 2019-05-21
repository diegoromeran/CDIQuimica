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
        

        //Monoxido
        carbono = GameObject.Find("nucleoC");
        monoxido = GameObject.Find("Monoxido");
        monoxido.SetActive(false);
        monoxido.SetActive(!monoxido.activeInHierarchy);
        
        //Agua
        hidrogeno = GameObject.Find("nucleoH");
        oxigeno = GameObject.Find("nucleoO");
        agua = GameObject.Find("Agua");
        agua.SetActive(false);
        agua.SetActive(!agua.activeInHierarchy);

        //Metano
        metano = GameObject.Find("Metano");
        metano.SetActive(false);
        metano.SetActive(!metano.activeInHierarchy);

        //Amoniaco
        nitrogeno = GameObject.Find("nucleoN");
        amoniaco = GameObject.Find("Amoniaco");
        amoniaco.SetActive(false);
        amoniaco.SetActive(!amoniaco.activeInHierarchy);

        //Sal
        sodio = GameObject.Find("nucleoNa");
        cloro = GameObject.Find("nucleoCl");
        sal = GameObject.Find("Sal");
        sal.SetActive(false);
        sal.SetActive(!sal.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
       
        //Monoxido
        if(Vector3.Distance(carbono.transform.parent.transform.position, oxigeno.transform.parent.transform.position) < 10) {
            oxigeno.transform.position = new Vector3(-1000, -1000, -1000);
            carbono.transform.position = new Vector3(-1000, -1000, -1000);
            monoxido.SetActive(true);
            monoxido.transform.position = (oxigeno.transform.parent.transform.position + carbono.transform.parent.transform.position)/2;
        }
        if(Vector3.Distance(carbono.transform.parent.transform.position, oxigeno.transform.parent.transform.position) > 15) {
            oxigeno.transform.position = oxigeno.transform.parent.transform.position;
            carbono.transform.position = carbono.transform.parent.transform.position;
            monoxido.SetActive(false);
        }

         //Agua
       if(Vector3.Distance(hidrogeno.transform.parent.transform.position, oxigeno.transform.parent.transform.position) < 10) {
            oxigeno.transform.position = new Vector3(-1000, -1000, -1000);
            hidrogeno.transform.position = new Vector3(-1000, -1000, -1000);
            agua.SetActive(true);
            agua.transform.position = (oxigeno.transform.parent.transform.position + hidrogeno.transform.parent.transform.position)/2;
        }
        if(Vector3.Distance(hidrogeno.transform.parent.transform.position, oxigeno.transform.parent.transform.position) > 15) {
            oxigeno.transform.position = oxigeno.transform.parent.transform.position;
            hidrogeno.transform.position = hidrogeno.transform.parent.transform.position;
            agua.SetActive(false);
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
        if(Vector3.Distance(hidrogeno.transform.parent.transform.position, nitrogeno.transform.parent.transform.position) < 10) {
            hidrogeno.transform.position = new Vector3(-1000, -1000, -1000);
            nitrogeno.transform.position = new Vector3(-1000, -1000, -1000);
            amoniaco.SetActive(true);
            amoniaco.transform.position = (hidrogeno.transform.parent.transform.position + nitrogeno.transform.parent.transform.position)/2;
        }
        if(Vector3.Distance(hidrogeno.transform.parent.transform.position, nitrogeno.transform.parent.transform.position) > 15) {
            hidrogeno.transform.position = hidrogeno.transform.parent.transform.position;
            nitrogeno.transform.position = nitrogeno.transform.parent.transform.position;
            amoniaco.SetActive(false);
        }

        //Sal
        if(Vector3.Distance(sodio.transform.parent.transform.position, cloro.transform.parent.transform.position) < 10) {
            sodio.transform.position = new Vector3(-1000, -1000, -1000);
            cloro.transform.position = new Vector3(-1000, -1000, -1000);
            sal.SetActive(true);
            sal.transform.position = (sodio.transform.parent.transform.position + cloro.transform.parent.transform.position)/2;
        }
        if(Vector3.Distance(sodio.transform.parent.transform.position, cloro.transform.parent.transform.position) > 15) {
            sodio.transform.position = sodio.transform.parent.transform.position;
            cloro.transform.position = cloro.transform.parent.transform.position;
            sal.SetActive(false);
        }
    }
}
