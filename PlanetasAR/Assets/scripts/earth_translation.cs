using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class earth_translation : MonoBehaviour {

    // Use this for initialization
    float contador = 0.0f;
    public float velocidad;
    public float distance;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(Mathf.Cos(contador) * distance, 0, Mathf.Sin(contador) * distance);
        contador = contador + velocidad;
    }
}
