using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public GameObject canvas;
    public Button pause;
    public Button Mulai;
    public GameObject Menu;

    public void berhenti()
    {
        Menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void lanjut()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
    }
}
