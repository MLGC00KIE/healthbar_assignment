using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDownScript : MonoBehaviour {

    public Health health;

    public void HealthDown()
    {
        if(health.GetHealth() >= 1)
            health.SetHealth(health.GetHealth() - 1);
    }
}
