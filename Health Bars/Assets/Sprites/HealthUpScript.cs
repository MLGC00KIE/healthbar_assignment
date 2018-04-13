using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUpScript : MonoBehaviour {

	public void HealthUp()
    {
        if(Health.GetHealth() <= 2)
            Health.SetHealth(Health.GetHealth() + 1);
    }
}
