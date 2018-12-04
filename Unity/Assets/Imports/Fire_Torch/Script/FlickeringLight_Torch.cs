using UnityEngine;
using System.Collections;

public class FlickeringLight_Torch : MonoBehaviour {
    [SerializeField]
    private Light fuseLight;
    [SerializeField]
	private float fuseLightIntensity = 1;
    [SerializeField]
    private float deviancy = 0.2f;

	void Start (){

	}

	void Update (){
		fuseLight.intensity = (Random.Range(fuseLightIntensity - deviancy, fuseLightIntensity + deviancy)); ;
	}
}