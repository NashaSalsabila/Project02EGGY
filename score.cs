using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {
	//player
	public Transform player;
	public Text scoretext;

	void Update () { 
		scoretext.text = player.position.z.ToString("0");
	
	}
}
