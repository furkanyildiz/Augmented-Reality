using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    // Use this for initialization

    Transform obje;
    public float speed;


    void Start () {
        obje = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
         transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
