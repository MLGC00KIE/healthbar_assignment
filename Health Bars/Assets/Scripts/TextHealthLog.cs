using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHealthLog : MonoBehaviour {

    public Health health;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    void Update () {
        text.text = "Health: " + health.GetHealth();
	}
}
