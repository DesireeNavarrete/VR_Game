using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palancas : MonoBehaviour
{
    public GameObject pal1, pal2, pal3, pal4, pal5, pal6, pal7, pal8, pal9, pal10;
    Animator animPal,animPal2, animPal3, animPal4, animPal5, animPal6, animPal7, animPal8, animPal9, animPal10;
    bool arriba1, arriba2, arriba3, arriba4, arriba5, arriba6, arriba7, arriba8, arriba9, arriba10;
    public Light luzRoja, luzAma, luzAzul, luzVerde,luzGeneral;
    // Start is called before the first frame update
    void Start()
    {
        

        animPal =pal1.GetComponent<Animator>();
        arriba1 = true;

        animPal2 = pal2.GetComponent<Animator>();
        arriba2 = true;
        
        animPal3 = pal3.GetComponent<Animator>();
        arriba3 = true;

        animPal4 = pal4.GetComponent<Animator>();
        arriba4 = true;

        animPal5 = pal5.GetComponent<Animator>();
        arriba5 = true;

        animPal6 = pal6.GetComponent<Animator>();
        arriba6 = true;

        animPal7 = pal7.GetComponent<Animator>();
        arriba7 = true;

        animPal8 = pal8.GetComponent<Animator>();
        arriba8 = true;

        animPal9 = pal9.GetComponent<Animator>();
        arriba9 = true;

        animPal10 = pal10.GetComponent<Animator>();
        arriba10 = true;

    }


    // Update is called once per frame
    void Update()
    {
        if (arriba1&&arriba2==false&&arriba3==false&&arriba4&&arriba5==false)//palancas correctas para comprobar de la primera parte
        {
            print("correcto");
            luzRoja.enabled = false;
        }
        else
            print("incorrecto");


        if (arriba6 && arriba7 && arriba8 == false && arriba9 && arriba10)//palancas correctas para comprobar de la segunda parte
        {
            print("correcto2");
            luzAma.enabled = false;
            luzAzul.enabled = false;
            luzVerde.enabled = false;
            luzGeneral.enabled = true;




        }
        else
            print("incorrecto2");
    }

    private void OnTriggerEnter(Collider other)
    {
        //primera palanca
        if (other.transform.tag == "pal1") {
        print("Tocado palanca " + other.gameObject.name);
        animPal.SetTrigger("palanca1");
        arriba1 = !arriba1;
        }

        //segunda palanca
        if (other.transform.tag == "pal2")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal2.SetTrigger("palanca2");
            arriba2 = !arriba2;
        }

        //tercera palanca
        if (other.transform.tag == "pal3")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal3.SetTrigger("palanca3");
            arriba3 = !arriba3;
        }

        //cuarta palanca
        if (other.transform.tag == "pal4")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal4.SetTrigger("palanca4");
            arriba4 = !arriba4;
        }

        //quinta palanca
        if (other.transform.tag == "pal5")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal5.SetTrigger("palanca5");
            arriba5 = !arriba5;
        }

        //sexta palanca
        if (other.transform.tag == "pal6")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal6.SetTrigger("palanca6");
            arriba6 = !arriba6;
        }
        //septima palanca
        if (other.transform.tag == "pal7")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal7.SetTrigger("palanca7");
            arriba7 = !arriba7;
        }
        //quinta palanca
        if (other.transform.tag == "pal8")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal8.SetTrigger("palanca8");
            arriba8 = !arriba8;
        }
        //octava palanca
        if (other.transform.tag == "pal9")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal9.SetTrigger("palanca9");
            arriba9 = !arriba9;
        }
        //decima palanca
        if (other.transform.tag == "pal10")
        {
            print("Tocado palanca " + other.gameObject.name);
            animPal10.SetTrigger("palanca10");
            arriba10 = !arriba10;
        }
    }
}
