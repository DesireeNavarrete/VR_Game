using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{

    //public int[] codCorrecto = { 1, 3, 7, 9, 2, 4 };//array 
    public int[] codCorrecto = { 1, 2,3,6,9,8 };//array 

    public int[] codIntroducido;
    //public GameObject num1,num2,num3,num4,num5,num6,num7,num8,num9,num0;
    public int secuencia, num_cubo;
        public int contador;

    public Light led1, led2;
    public Text num;
    public GameObject puerta;
    public bool cod1, cod2;
    Animator caja;
    //public int[] codCorrecto = { 1, 3, 7, 9, 2, 4 };//array 
    public int[] codCorrectoColor = { 1, 1, 1, 1 };//array 

    public int[] codIntroducidoColor;
    //public GameObject num1,num2,num3,num4,num5,num6,num7,num8,num9,num0;
    public int secuenciaColor, num_color;

    //public Text numColor;


    // Start is called before the first frame update
    void Start()
    {

        contador = 0;
        led1.enabled = false;
        led2.enabled = false;
        cod1 = false;
        cod2 = false;
        caja = puerta.GetComponent<Animator>();

        caja.SetBool("open", false);

        secuencia = 0;
        num.text = "";

        secuenciaColor = 0;
        //numColor.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (contador == 1)
        {
            contador = 0;
        }
        if (cod1 && cod2)
        {
            caja.SetBool("open", true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "boton") { 
        print("Tocado botón " + other.gameObject.name);
        if (secuencia < 6 &&contador==0 )
        {

            num_cubo = System.Int32.Parse(other.gameObject.name);
            codIntroducido[secuencia] = num_cubo;
            secuencia++;
            num.text += num_cubo;
            contador = 1;
            print(contador);

        }
        if (secuencia == 6)
        {
            for (int i = 0; i < codIntroducido.Length; i++)
            {
                if(codIntroducido[i] == codCorrecto[i])
                {
                    print("correcto");
                        cod1 = true;
                        led1.enabled = true;
                    }
                if(codIntroducido[i] != codCorrecto[i])
                {
                    print("incorrecto");
                    num.text = "";
                    secuencia = 0;
                    for (int x = 0; x < codIntroducido.Length; x++)//borra el array
                    {
                        codIntroducido[x] = 0;

                    }
                }

                }
            }
        }


        if (other.transform.tag == "BotonesColor") { 
        print("Tocado botón " + other.gameObject.name);
        if (secuenciaColor < 4)
        {

            num_color = System.Int32.Parse(other.gameObject.name);
            codIntroducidoColor[secuenciaColor] = num_color;
            secuenciaColor++;
            //num.text += num_cubo;
            //print(secuencia +" ");

        }
        if (secuenciaColor == 4 && contador == 0)
        {
                for (int i = 0; i < codIntroducidoColor.Length; i++)
                {
                    if (codIntroducidoColor[i] == codCorrectoColor[i])
                    {
                        print("correcto");
                        cod2 = true;
                        led2.enabled = true;
                        num.text = "";
                        contador = 1;

                    }
                    if (codIntroducidoColor[i] != codCorrectoColor[i])
                    {
                        print("incorrecto");
                        //numColor.text = "";
                        secuenciaColor = 0;
                        for (int x = 0; x < codIntroducidoColor.Length; x++)//borra el array
                        {
                            codIntroducidoColor[x] = 0;

                        }
                    }
                }
            }
        }
    }


    }

