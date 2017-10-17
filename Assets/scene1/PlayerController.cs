using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float playerSpeed = 10;
	private float moveHoriz;
	private float moveVert;
	SpriteRenderer sr;
	CircleCollider2D col;
	public Transform hexagon;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer>();
		col = GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		moveHoriz = Input.GetAxis("Horizontal");
		moveVert = Input.GetAxis("Vertical");
		transform.position += new Vector3(moveHoriz, moveVert) * Time.fixedDeltaTime * playerSpeed;

		if(col.transform.position.y-.37 > 0){
			sr.sortingOrder = 3;
		}
		else{
			sr.sortingOrder = 6;
		}

		if(Input.GetKeyDown(KeyCode.Z)){
			Instantiate(hexagon,transform.position,Quaternion.identity);
		}


	}
}
