using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardBehavior : MonoBehaviour {

	public int waittime = 2;
	public int direction = 1;

	// Use this for initialization
	void Start () {
		StartCoroutine(GuardRotate());
	}
	
	IEnumerator GuardRotate(){
		while(true){
			yield return new WaitForSeconds(waittime);
			transform.Rotate(0f,0f,90f*direction);
		}		
	}

}
