using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigController : MonoBehaviour {
    GameObject playerarm;
    float trun = 0;
    int hp = 10;
    bool see = false;
    bool running = false;
	// Use this for initialization
	void Start () {
        playerarm = GameObject.Find("PlayerArm");
	}
	
	// Update is called once per frame
	void Update () {
		if(hp<=0)
        {
            Destroy(gameObject);
        }
        if (running)
            run();

	}
    void OnTriggerEnter (Collider other)
    {
        if(other==playerarm.GetComponent<Collider>())
        {
            hp -= 3;
            running = true;
        }
        
    }

    void run()
    {

        if (!see&&trun<10)
        {
            gameObject.transform.LookAt(playerarm.transform.position);
            gameObject.transform.Rotate(0, 0, 0);
            see = true;
            trun++;
        }
        if (trun >= 10)
            trun = 0;
        gameObject.transform.Translate(Vector3.back * Time.deltaTime * 0.5f);

    }
}
