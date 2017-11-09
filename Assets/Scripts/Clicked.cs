using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour {

    private bool displayed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (displayed)
        {
            this.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Close");
        } else
        {
            this.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Open");
        }
        displayed = !displayed;
    }
}
