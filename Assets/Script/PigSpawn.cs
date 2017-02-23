using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigSpawn : MonoBehaviour {
    public GameObject PigModel;
    public float AllTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AllTime += Time.deltaTime;
        if(GameObject.FindGameObjectsWithTag("PigTag").Length<5)
        {
            Vector3 position = new Vector3(Random.Range(-7f, 8.5f), 5, Random.Range(0,10f));
            var myNewpig= Instantiate(PigModel, position, Quaternion.identity);
            myNewpig.transform.parent = gameObject.transform;
        }
	}
}
