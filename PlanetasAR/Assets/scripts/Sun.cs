using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    // Use this for initialization
    public float xx;
    public float yy;
    public float zz;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * yy);
        transform.Rotate(Vector3.right * Time.deltaTime * xx);
        transform.Rotate(Vector3.forward * Time.deltaTime * zz);
    }
}
