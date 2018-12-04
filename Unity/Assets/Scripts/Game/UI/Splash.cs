using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Splash : MonoBehaviour {
    public Text text;
    public int duration;
    private float timey;
    public AnimationCurve path;
    public Gradient backColor;
    public Gradient foreColor;
    private bool running;
    private RectTransform t;
    
    public static Splash instance = null;

    private void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }

        //If instance already exists and it's not this:
        else if (instance != this)
        {
            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        }
    }

    void Start()
    {
        t = this.gameObject.GetComponent<RectTransform>();
        running = true;
        timey = 0;
        text.text = "Round 1";
    }

    // Update is called once per frame
    void Update () {
        if (running)
        {
            float sizeAtm = path.Evaluate(timey / duration * path.keys[path.length - 1].time);
            t.localScale = new Vector3(sizeAtm, sizeAtm, 1);
            foreach (Image img in this.gameObject.GetComponentsInChildren<Image>())
            {
                img.color = backColor.Evaluate(timey / duration * 2);
            }
            text.color = foreColor.Evaluate(timey / duration * 2);

            timey += Time.deltaTime;
            if (timey >= duration)
            {
                t.gameObject.SetActive(false);
                running = false;
            }
        }
	}

    public void StartSplash()
    {
        timey = 0;
        t.gameObject.SetActive(true);
        running = true;
    }

    public void SetRoundNumber(int roundNumber)
    {
        text.text = string.Format("Round {0}", roundNumber);
    }
}
