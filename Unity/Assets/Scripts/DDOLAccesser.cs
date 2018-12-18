using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOLAccesser : MonoBehaviour {
    
    private static GameObject DDOLObject;
    
	void Awake () {
        DDOLObject = gameObject;

        DontDestroyOnLoad(gameObject);
    }

    public static GameObject GetObject()
    {
        return DDOLObject;
    }
}
