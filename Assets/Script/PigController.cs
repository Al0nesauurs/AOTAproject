using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigController : MonoBehaviour {
    Transform playerarm;
    float trun = 0;
    private float hp = 12;
    public static float damageApply = 0;
    bool running = false;
    bool fliping = false;
	// Use this for initialization
	void Start () {
        playerarm = GameObject.Find("PlayerArm").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update () {

        if (running)
        {
            if(fliping)
                flip();
            run(trun += Time.deltaTime);

        }


	}

    public void HpController(int damage)
    {
        Debug.Log("HP CON!");
        running = true;
        fliping = true;
        hp -= damage;
        if (hp <= 0)
            Destroy(gameObject);
    }
    void run(float timerun)
    {

        if (timerun >= 3)
        {
            running = false;
            trun = 0;
        }
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 0.5f);

    }

    void flip()
    {
        var targetPosition = playerarm.position;
        targetPosition.y = transform.position.y;
       targetPosition.z = 0;
        targetPosition.x = 0;
        if (fliping)
        {
            gameObject.transform.LookAt(targetPosition);
            gameObject.transform.Rotate(0, 180, 0);
            fliping = false;
        }
    }
}
