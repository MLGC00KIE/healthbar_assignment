using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveCounter : MonoBehaviour
{
    public Health health;

    [SerializeField]
    Sprite zero;
    [SerializeField]
    Sprite one;
    [SerializeField]
    Sprite two;
    [SerializeField]
    Sprite three;

    Image lives;


    // Use this for initialization
    void Start()
    {
        lives = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (health.GetHealth())
        {
            case 0:
                lives.sprite = zero;
                break;
            case 1:
                lives.sprite = one;
                break;
            case 2:
                lives.sprite = two;
                break;
            case 3:
                lives.sprite = three;
                break;

        }
    }



}