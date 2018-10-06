using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMotionA : MonoBehaviour {

    public float motionSpeed;

    public float rotationSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Rotate(0, 0, rotationSpeed);
        
        this.transform.Translate(Vector3.forward * motionSpeed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Objetivo Eliminado");

        //Destruimos el misil
        GameObject.Destroy(this.gameObject);

        //Destruimos el enemigo
        GameObject.Destroy(collision.collider.gameObject);	
	}
}
