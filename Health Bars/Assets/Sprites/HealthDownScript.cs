using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDownScript : MonoBehaviour {

	public void HealthDown()
    {
        if(Health.GetHealth() >= 1)
            Health.SetHealth(Health.GetHealth() - 1);
    }
}
