using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text ui_text;
	// Use this for initialization
	void Start () {
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);
        ui_text.text = a.ToString() + " + " + b.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
