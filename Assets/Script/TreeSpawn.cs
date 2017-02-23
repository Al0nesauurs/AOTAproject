using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour {
    public GameObject Treemodel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectsWithTag("TreeTag").Length < 5)
        {
            Vector3 position = new Vector3(Random.Range(-7f, 8.5f), 5, Random.Range(0, 10f));
            var myNewtree = Instantiate(Treemodel, position, Quaternion.identity);
            myNewtree.transform.parent = gameObject.transform;
        }
    }
}
