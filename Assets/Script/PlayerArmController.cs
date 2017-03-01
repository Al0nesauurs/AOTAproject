using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArmController : MonoBehaviour {
    private float t=0;
    private bool hit = false;
    private ItemController Itemscript;
    private Transform ArmLocate;
	// Use this for initialization
	void Start () {
        ArmLocate = GameObject.Find("ArmPosition").transform;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0)||Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Hit!");
            if(Input.GetKeyDown(KeyCode.Mouse0))
             hit = true;
            else if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                RaycastHit vHit = new RaycastHit();
                Ray vRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(vRay, out vHit,2f))
                {
                    if (vHit.collider.gameObject.tag == "ItemTag")
                    {
                        Debug.Log("THIS IS ITEM NAME : " + vHit.collider.gameObject);
                        Itemscript = (ItemController)vHit.collider.gameObject.GetComponent(typeof(ItemController));
                        Itemscript.HpController(100);

                    }

                }
            }
        }   
        
        if(hit==true)
        {
            t += Time.deltaTime;
            if(t<=0.05)
            MeleeSystem.clicked = true;

            if (t <= 0.4)
            {
                gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 1f);
            }
            if (t >= 0.4 )
            {
                gameObject.transform.Translate(Vector3.back * Time.deltaTime * 1f);
            }
            if (t >= 0.8)
            {
                gameObject.transform.position = ArmLocate.transform.position;
                hit = false;
                t = 0;
            }
         }


    }
}
