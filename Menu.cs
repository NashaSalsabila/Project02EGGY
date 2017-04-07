using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	public Button Play;
	public Button Help;
	public Button About;
	public Button Exit;
	public Button MainMenu;
	// Use this for initialization

	public void MulaiGame () {
		Application.LoadLevel ("game");
	}

	public void KembaliMenu(){
		Application.LoadLevel ("MainMenu");
	}

	public void Bantuan(){
		Application.LoadLevel ("help");
	}

	public void TentangKita(){
		Application.LoadLevel ("aboutus");
	}

	public void KeluarGame(){
		Application.Quit();
	}
}
