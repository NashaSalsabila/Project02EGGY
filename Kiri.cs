using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kiri : MonoBehaviour {

    public GameObject canvas;
    public Button kiri;
    public Button kanan;

    public void tekankiri()
    {
        (GameObject.Find("Player")).transform.Translate(-30f * Time.deltaTime, 0, 0);
    }

    public void tekankanan()
    {
        (GameObject.Find("Player")).transform.Translate(30f * Time.deltaTime, 0, 0);
    }

}
