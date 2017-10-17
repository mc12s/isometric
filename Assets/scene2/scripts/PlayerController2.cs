using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

	public float speed;
	float move_h;
	float move_v;
	private bool player_high = true;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer>();
	}


	void Update(){
		if(Input.GetKeyDown(KeyCode.Z)){
			if(player_high){
				gameObject.layer = 11;
				sr.sortingOrder = 1;
			}
			else{
				gameObject.layer = 10;
				sr.sortingOrder = 3;
			}
			player_high=!player_high;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		move_h = Input.GetAxis("Horizontal");
		move_v = Input.GetAxis("Vertical");
		transform.position += new Vector3(move_h,move_v) * speed;
	}


	void OnTriggerEnter2D(Collider2D col){
		print(col);
		if(col.CompareTag("up")){
			Debug.Log("up");
			gameObject.layer = 10;
			sr.sortingOrder = 3;
		}
		else if(col.CompareTag("down")){
			Debug.Log("up");
			gameObject.layer = 11;
			sr.sortingOrder = 1;
		}

		if(col.CompareTag("star")){
			col.gameObject.SetActive(false);
		}
	}

}
