using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardSight : MonoBehaviour {

	public GameObject alarm;

	void OnTriggerEnter2D(Collider2D col){
		if(col.CompareTag("Player")){
			print("Guard Spotted You!");
			alarm.GetComponent<Animator>().Play("alarm");
		}
	}

}
