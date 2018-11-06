using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class simplerotate : MonoBehaviour {

    private RectTransform rectComponent;
    private Image imageComp;
    private bool up = false;
    private float filly;

    public float rotateSpeed = 200f;

    // Use this for initialization
    void Start()
    {
        rectComponent = GetComponent<RectTransform>();
        imageComp = rectComponent.GetComponent<Image>();
        filly = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!up)
        {
            filly -= 0.05f;
            if (filly <= 0.2f)
            {
                up = true;
            }
        }
        else
        {
            filly += 0.05f;
            if (filly >= 1f)
            {
                up = false;
            }
        }

        imageComp.fillAmount = filly;
    }
}