using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public Text countText;
	public Text winText;
	private Rigidbody rb;
	private int count;
	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText();
		winText.text = "";
	}
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce(movement * speed);
		if (Input.GetKeyDown ("space")) {
        	Vector3 jump = new Vector3 (0.0f, 200.0f, 0.0f);
        	GetComponent<Rigidbody>().AddForce (jump);
   		}
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive(false);
			speed++;
			count++;
			SetCountText();
		}
		else if (other.gameObject.CompareTag("Pick Down")) {
			other.gameObject.SetActive(false);
		}
	}
	void SetCountText() {
		countText.text = "Count: " + count.ToString();
		if (count >= 14) {
			winText.text = "You Win!";
		}
	}
}
