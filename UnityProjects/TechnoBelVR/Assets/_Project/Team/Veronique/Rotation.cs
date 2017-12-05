using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    [SerializeField]
    GameObject object1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown())
        {
            Instantiate(b, Camera.main.transform.position, Camera.main.transform.rotation);// on tire les balles par rapport à l'endroit où nous sommes.

        }


    }
}
