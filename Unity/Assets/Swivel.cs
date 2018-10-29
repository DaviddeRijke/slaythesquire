using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swivel : MonoBehaviour {
    public float rotationsPerMinute = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate((float)(6.0 * rotationsPerMinute * Time.deltaTime), 0, 0);
    }
}
