using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private bool CanWalk = true;
    private bool CanJump = true;
    static public bool reacable = false;
    public float force = 5;
    public float MouseSpeed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Mouse rotate control
        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

        if (Input.GetAxis("Horizontal")!=0&&CanWalk)
        {
            gameObject.transform.Translate(Input.GetAxis("Horizontal") *Vector3.right*Time.deltaTime * 1f*force);
        }

        if(Input.GetAxis("Vertical")!=0&&CanWalk)
        {
            gameObject.transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * 1f*force);
        }

        if(Input.GetKeyDown(KeyCode.Space)&&CanJump)
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime * 1f*force);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if(CanWalk&&CanJump)
            {
                CanWalk = false;
                CanJump = false;
            }
            else if(!CanWalk&&!CanJump)
            {
                CanWalk = true;
                CanJump = true;
            }
        }

    }
}
