using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayAnim : MonoBehaviour {

    private Animator anim;

    void Awake()
    {
        anim = this.GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        anim.Play("EL");
    }

}
