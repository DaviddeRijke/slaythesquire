using UnityEngine;
using System.Collections;

public class camDemo : MonoBehaviour {		// This class shows how to use the pack. Init: visEffects.staticInit (); and spawn: visEffects.createEffect();
	int eIndex;
	Vector3 eOffset;
	void Start () {
		eIndex = -1;
		visEffects.staticInit ();
	}
	void Update () {
		visEffects.update();
		if (Input.GetKeyDown(KeyCode.Space)) {
			eIndex++;
		}
		if (Input.anyKeyDown) {
			if (eIndex >= (int)visualEffectNames.size || eIndex < 0)
				eIndex = 0;
			//eIndex = (int)visualEffectNames.vacuumExplosion;		// debug, to play a particular effect
			if (visEffects.effectIsGround(eIndex))
				eOffset = new Vector3(0, 0, 0);
			else
				eOffset = new Vector3(0, 0.5f, 0);
			visEffects.createEffect(eIndex, eOffset);
			Debug.Log((visualEffectNames)eIndex);									// uncomment this to see the number of the current effect in the console
			if (eIndex == (int)visualEffectNames.size)
				eIndex = 0;
		}
	}
}
