 using UnityEngine;


public class PlayerCollision : MonoBehaviour {
	public PlayerMove movement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Cube")
		{
			movement.enabled = false;
			FindObjectOfType<GameOver>().End();
		}
	}
}
  