using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigController : MonoBehaviour {
    Transform playerarm;
    float trun = 0;
    private float hp = 6;
    public static float damageApply = 0;
    bool see = false;
    bool running = false;
	// Use this for initialization
	void Start () {
        playerarm = GameObject.Find("PlayerArm").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update () {

        if (running)
            run();


	}

    public void HpController(int damage)
    {
        Debug.Log("HP CON!");
        running = true;
        hp -= damage;
        if (hp <= 0)
            Destroy(gameObject);
    }
    void run()
    {
        var targetPosition = playerarm.position;
        targetPosition.y = transform.position.y;
        if (!see&&trun<10)
        {
            gameObject.transform.LookAt(targetPosition);
            gameObject.transform.Rotate(0, 0, 0);
            see = true;
            trun++;
        }
        if (trun >= 10)
            trun = 0;
        gameObject.transform.Translate(Vector3.back * Time.deltaTime * 0.5f);

    }
}
