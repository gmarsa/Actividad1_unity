using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Seleccion : MonoBehaviour
{
    public Color color;
    public MeshRenderer meshRenderer;
    public Transform[] persona;
    public bool personaje1 =false;
    public bool personaje2 =false;
    public bool personaje3 =false;
    public bool personaje4 =false;
    // Start is called before the first frame update
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
          personaje1 = true;
           personaje2 = false;
          personaje3 = false;
         personaje4 = false;



        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           personaje1 = false;
           personaje2 = true;
           personaje3 = false;
           personaje4 = false;


        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            personaje1 = false;
            personaje2 = false;
            personaje3 = true;
            personaje4 = false;


        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
             personaje1 = false;
             personaje2 = false;
             personaje3 = false;
             personaje4 = true;


        }

        //personaje 1
        if (Input.GetKeyDown(KeyCode.A) && personaje1 == true)
        {
 
            persona[0].transform.position += Vector3.left;


        }
        else if (Input.GetKeyDown(KeyCode.D) && personaje1 == true)
        {
      
            persona[0].transform.position += Vector3.right;



        }
        else if (Input.GetKeyDown(KeyCode.W) && personaje1 == true)
        {

            persona[0].transform.position += Vector3.up;


        }
        else if (Input.GetKeyDown(KeyCode.S) && personaje1 == true)
        {

            persona[0].transform.position += Vector3.down;



        }
        else if (Input.GetKeyDown(KeyCode.Q) && personaje1 == true)
        {

            persona[0].transform.position += Vector3.forward;


        }
        else if (Input.GetKeyDown(KeyCode.E) && personaje1 == true)
        {

            persona[0].transform.position += Vector3.back;



        }

        //personaje2
        if (Input.GetKeyDown(KeyCode.A) && personaje2 == true)
        {

            persona[0].transform.position += Vector3.left;


        }
        else if (Input.GetKeyDown(KeyCode.D) && personaje2 == true)
        {

            persona[1].transform.position += Vector3.right;



        }
        else if (Input.GetKeyDown(KeyCode.W) && personaje2 == true)
        {

            persona[1].transform.position += Vector3.up;


        }
        else if (Input.GetKeyDown(KeyCode.S) && personaje2 == true)
        {

            persona[1].transform.position += Vector3.down;



        }
        else if (Input.GetKeyDown(KeyCode.Q) && personaje2 == true)
        {

            persona[1].transform.position += Vector3.forward;


        }
        else if (Input.GetKeyDown(KeyCode.E) && personaje2 == true)
        {

            persona[1].transform.position += Vector3.back;



        }
        //persona 3
        if (Input.GetKeyDown(KeyCode.A) && personaje3 == true)
        {

            persona[2].transform.position += Vector3.left;


        }
        else if (Input.GetKeyDown(KeyCode.D) && personaje3 == true)
        {

            persona[2].transform.position += Vector3.right;



        }
        else if (Input.GetKeyDown(KeyCode.W) && personaje3 == true)
        {

            persona[2].transform.position += Vector3.up;


        }
        else if (Input.GetKeyDown(KeyCode.S) && personaje3 == true)
        {

            persona[2].transform.position += Vector3.down;



        }
        else if (Input.GetKeyDown(KeyCode.Q) && personaje3 == true)
        {

            persona[2].transform.position += Vector3.forward;


        }
        else if (Input.GetKeyDown(KeyCode.E) && personaje3 == true)
        {

            persona[2].transform.position += Vector3.back;



        }
        //personaje4
        if (Input.GetKeyDown(KeyCode.A) && personaje4 == true)
        {

            persona[3].transform.position += Vector3.left;


        }
        else if (Input.GetKeyDown(KeyCode.D) && personaje4 == true)
        {

            persona[3].transform.position += Vector3.right;



        }
        else if (Input.GetKeyDown(KeyCode.W) && personaje4 == true)
        {

            persona[3].transform.position += Vector3.up;


        }
        else if (Input.GetKeyDown(KeyCode.S) && personaje4 == true)
        {

            persona[3].transform.position += Vector3.down;



        }
        else if (Input.GetKeyDown(KeyCode.Q) && personaje4 == true)
        {

            persona[3].transform.position += Vector3.forward;


        }
        else if (Input.GetKeyDown(KeyCode.E) && personaje4 == true)
        {

            persona[3].transform.position += Vector3.back;



        }


    }
}
