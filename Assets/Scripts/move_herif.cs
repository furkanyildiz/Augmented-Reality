using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_herif : MonoBehaviour {

    public float step_x = 0.01f;
    public float speed = 100f;

    private float count = 0;
    private float MAX = 5f;
    private Vector3 firstpose;
    private Vector3 targetpose;

    private bool rotated = false;

    // Use this for initialization
    void Start () {
        //herif.GetComponent<Transform>();
        firstpose = transform.position;
        targetpose = firstpose + new Vector3(5f,0,0);
    }
	
	// Update is called once per frame
	void Update () {
        //transform.position = Vector3.Lerp(firstpose, targetpose, Time.deltaTime * speed);
        
        //transform.position = Vector3.Lerp(firstpose, targetpose, Mathf.PingPong(Time.deltaTime * speed, 1.0f));

        
        if (count < MAX && !rotated)
        {
            transform.position += new Vector3(step_x, 0, 0);
            count += step_x;
            rotated = false;
        }
        if (count >= MAX && !rotated)
        {
            transform.Rotate(0, 270 * Time.deltaTime, 0);
            rotated = true;
        }
        if(count > 0 && rotated)
        {
            transform.position -= new Vector3(step_x, 0, 0);
            count -= step_x;
            rotated = true;
            if (count <= 0)
            {
                rotated = false;
                transform.Rotate(0, 270 * Time.deltaTime, 0);
            }


        }



    }









    /*
    if (transform.localPosition.x < 0.25)
        transform.localPosition.x = transform.localPosition.x * 0.01 ;
        */


}
