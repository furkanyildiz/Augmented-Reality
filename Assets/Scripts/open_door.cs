using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour {

    public int degree;
    public LayerMask touchInputMask;
    private string hitted_object_name;
    public Camera cam;


    // Update is called once per frame
    void Update () {


        foreach (Touch touch in Input.touches)
        {
            Debug.Log("touch!");

            Ray ray = cam.ScreenPointToRay(touch.position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                name = hit.transform.name;
                Debug.Log("Hit edilen obje:" + name);


                if (hitted_object_name == "The fence")
                {
                    transform.Rotate(0, degree * Time.deltaTime, 0);

                }


            }

        }




        /*
        Quaternion target = Quaternion.Euler(0, degree, 0);

        transform.rotation = target; 
        */
    }
}
