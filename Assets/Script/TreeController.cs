using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour {
    private GameObject PlayerArm;
    private int Delete = 0;
    private float hp = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    	
	}


    public void HpController(int damage)
    {

        hp -= damage;
        if (hp <= 0)
            Destroy(gameObject);
    }

}
