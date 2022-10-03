using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoverControl : MonoBehaviour
{
    public Transform[] figuras;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Moure a la dreta
        if (Input.GetKeyDown("z"))
        {
            print("S'ha pres la tecla z");
            figuras[0].transform.position += Vector3.right;

        }else if (Input.GetKeyDown("x"))
        {
            print("S'ha pres la tecla x");
            figuras[1].transform.position+= Vector3.right;
        }else if (Input.GetKeyDown("c"))
        {
            print("S'ha pres la tecla c");
            figuras[2].transform.position += Vector3.right;
        }
        else if (Input.GetKeyDown("v"))
        {
            print("S'ha pres la tecla v");
            figuras[3].transform.position += Vector3.right;
        }
        else if (Input.GetKeyDown("b"))
        {
            print("S'ha pres la tecla b");
            figuras[4].transform.position += Vector3.right;
        }
        //Moure a la esquerra
        else if (Input.GetKeyDown("q"))
        {
            print("S'ha pres la tecla q");
            figuras[0].transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown("w"))
        {
            print("S'ha pres la tecla w");
            figuras[1].transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown("e"))
        {
            print("S'ha pres la tecla e");
            figuras[2].transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown("r"))
        {
            print("S'ha pres la tecla r");
            figuras[3].transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown("t"))
        {
            print("S'ha pres la tecla t");
            figuras[4].transform.position += Vector3.left;
        }
        //Moure cap a dalt
        else if (Input.GetKeyDown("a"))
        {
            print("S'ha pres la tecla a");
            figuras[0].transform.position += Vector3.up;
        }else if (Input.GetKeyDown("s"))
        {
            print("S'ha pres la tecla s");
            figuras[1].transform.position += Vector3.up;
        }else if (Input.GetKeyDown("d"))
        {
            print("S'ha pres la tecla d");
            figuras[2].transform.position += Vector3.up;
        }else if (Input.GetKeyDown("f"))
        {
            print("S'ha pres la tecla f");
            figuras[3].transform.position += Vector3.up;
        }else if (Input.GetKeyDown("g"))
        {
            print("S'ha pres la tecla g");
            figuras[4].transform.position += Vector3.up;
        }
        //Reset
        else if (Input.GetKeyDown("space"))
        {
             
             figuras[0].transform.position = Vector3.zero;
             figuras[1].transform.position = Vector3.zero;
             figuras[2].transform.position = Vector3.zero;
             figuras[3].transform.position = Vector3.zero;
             figuras[4].transform.position = Vector3.zero;

        }
        //Control de posiciones(Ho faig una mica mes gran per a que se pugui comprovar)
        
          
            if (figuras[3].position.x > 10|| figuras[3].position.x < -10)
            {

                figuras[3].transform.position = Vector3.zero;

            }
            else if (figuras[4].position.x > 10|| figuras[4].position.x < -10)
            {

                figuras[4].transform.position = Vector3.zero;
               
            }

        



    }
}