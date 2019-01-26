using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setText : MonoBehaviour
{

    private GameObject go;
    public float num = 0.009f;
    //public GameObject spawnee;
    public Camera cam;
    string name;

    public TextMesh _text;

    void Start()
    {
        _text = _text.GetComponent<TextMesh>();
    }


    // Update is called once per frame
    void Update()
    {
        //Instantiate(spawnee);
        _text.text = "dene";


    }
}