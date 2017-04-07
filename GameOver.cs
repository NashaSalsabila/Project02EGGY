using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	bool gameHasOver = false;
	public float restartDelay = 0.01f;

	public void End()
	{
		if (gameHasOver == false)
		{
			gameHasOver = true;
			Debug.Log("GAME OVER!");
			Invoke ("restart", 0.01f); 
		}
	}

	void restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
 }
