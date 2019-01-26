using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch_movement : MonoBehaviour
{

    public GameObject go;
    //public float num = 0.009f;
    //public GameObject spawnee;
    public Camera cam;
    string name;


    public float open_door_degree = 10f;

    private bool open = false;
    /*
    void Start()
    {
        _text = _text.GetComponent<TextMesh>();

    }
    */
    // Update is called once per frame
    void Update()
    {
        //Instantiate(spawnee);

        foreach (Touch touch in Input.touches)
        {
            //Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                name = hit.transform.name;
                //go.transform.position += new Vector3(num, 0, 0);
                //_text.text = "_" + name + "_";
                
                if (name == "House")
                {

                    if (!open && go.transform.rotation.eulerAngles.y < 90)
                        go.transform.Rotate(go.transform.up * open_door_degree * Time.deltaTime);
                        //go.transform.Rotate(0, open_door_degree * Time.deltaTime, 0);

                    else if (!open && go.transform.rotation.eulerAngles.y >= 90)
                        open = true;

                    else if (open && go.transform.rotation.eulerAngles.y > 2)
                        go.transform.Rotate(-go.transform.up * open_door_degree * Time.deltaTime);
                        //go.transform.Rotate(Vector3.down * open_door_degree * Time.deltaTime);

                    else if (open && go.transform.rotation.eulerAngles.y <= 2)
                        open = false;

                    Debug.Log(go.transform.rotation.eulerAngles.y);

                }

            }

        }

        /*
        foreach (Touch touch in Input.touches)
        {
            Debug.Log("touch!");
            go.transform.position += new Vector3(num, 0, 0);

        }
        */

        /*

              if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                name = hit.transform.name;

                if (name == "The fence")
                {
                    go.transform.position += new Vector3(num, 0, 0);

                }
            }


        }

            if (Input.touchCount > 0)
        {

            Debug.Log("touch3!");
            go.transform.position += new Vector3(0, num, 0);


        }





        Touch[] touches = Input.touches;
        if (touches.Length > 0)
        {
            Debug.Log("touch2!");
            go.transform.position += new Vector3(0, 0, num);


        }

        */
    }
}