using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualEffectsController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        visEffects.staticInit();
    }

    public void PlayEffect(visualEffectNames effect, Vector3 position)
    {
        visEffects.createEffect((int)effect, position);
    }
}
