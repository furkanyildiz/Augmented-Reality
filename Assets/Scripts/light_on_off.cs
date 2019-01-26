using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_on_off : MonoBehaviour {

    public Light light_;

	
	public void pressesButton () {
        light_.enabled = !light_.enabled;
        print("dede");
    }

}
