using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon_translation : MonoBehaviour {

    // Use this for initialization
    public GameObject planeta;
    public float distance;
    float contador = 0.1f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(Mathf.Sin(contador) * distance, 0, Mathf.Cos(contador) * distance) + planeta.transform.position;
        contador = contador + 0.05f;
    }
}
