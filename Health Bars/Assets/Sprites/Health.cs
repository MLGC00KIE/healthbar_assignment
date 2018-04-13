using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField]
    public static int maxhealth = 3;
    [SerializeField]
    private static int health = 3;
	

    public static int GetHealth()
    {
        return health;
    }

    public static void SetHealth(int newHealth)
    {
        health = newHealth;
    }
}
