using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpScript : MonoBehaviour {

    public Health health;

	public void HealthUp()
    {
        if(health.GetHealth() <= 2)
            health.SetHealth(health.GetHealth() + 1);
    }
}
