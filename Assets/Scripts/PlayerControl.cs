using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float translationSpeed;

    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, translationSpeed);

        //Right
        if (Input.GetKey(KeyCode.RightArrow))
            this.transform.Translate(Vector3.right);

        //Left
        if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.Translate(Vector3.left);

        //Right
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.Translate(Vector3.up);

        //Right
        if (Input.GetKey(KeyCode.DownArrow))
            this.transform.Translate(Vector3.down);

        //Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Creamos un gameObject a partir de un prefab (planos de un edificio)
            //Esto es el código para crear más misiles que se disparan al presionar space
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);

            //Buscamos el gameObject del pivote de disparo (ShootPivot)
            GameObject shootPivot = GameObject.Find("MainShip/ShootPivot");

            //Hago el misil hijo de shoot pivot
            newMissile.transform.SetParent(shootPivot.transform);

            //Movemos el misil hijo de shoot pivot
            newMissile.transform.localPosition = Vector3.zero;

            //Saco el misil del pivote para que no se mueva con el avion
            newMissile.transform.SetParent(null);
        }

        }
    }