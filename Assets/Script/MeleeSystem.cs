using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSystem : MonoBehaviour {
    public static bool clicked = false;
    public PigController Pscript;
    public static int power = 1;
    // Use this for initialization
    private GameObject target;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter (Collider other)
    {
        if (clicked)
        {
            Debug.Log("Clicked");
            GameObject go = GameObject.Find("Pig");
            Pscript = (PigController)go.GetComponent(typeof(PigController));
            Pscript.HpController(power);

            //       target = other.gameObject;
            ApplyDamage(target);

            Debug.Log(target);
        }
    }

    void ApplyDamage(GameObject other)
    {
    }
}
