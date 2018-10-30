using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swivel : MonoBehaviour {
    public float rotationsPerMinute = 10.0f;
    public AnimationCurve curve;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (transform.localRotation.x >= 0.2f || transform.localRotation.x <= -0.2f)
        //{
        //    rotationsPerMinute = -1 * rotationsPerMinute;
        //}
        //transform.Rotate((float)(6.0 * rotationsPerMinute * Time.deltaTime), 0, 0);
        //transform.rotation.Set(rotationsPerMinute * (curve.Evaluate(Time.time % (curve.keys[curve.length - 1].time))), 0, 0, transform.rotation.w);
        float curveEvaluation = curve.Evaluate(Time.time % (curve.keys[curve.length - 1].time));
        float curveEvaluation2 = curve.Evaluate(Time.time % (curve.keys[curve.length - 1].time) * 2) / 4;
        float curveEvaluation3 = curve.Evaluate(Time.time % (curve.keys[curve.length - 1].time) * 3) / 4;
        transform.eulerAngles = new Vector3(curveEvaluation * rotationsPerMinute, curveEvaluation2 * rotationsPerMinute, -curveEvaluation3 * rotationsPerMinute);
    }
}
