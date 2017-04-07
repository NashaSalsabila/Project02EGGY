  using UnityEngine;
  using System.Collections;


public class PlayerMove : MonoBehaviour {
	public Rigidbody rb;
	public float forwardForce = 1500f;
	public float sidewaysForce = 500f;


    void FixedUpdate () {
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))
        {
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey("a"))
        {
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameOver>().End();
		}
	}
}
