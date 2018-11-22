using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text ui_text;
    public Text Answer1, Answer2, Answer3;
	// Use this for initialization
	void Start () {
        int a = Random.Range(0, 100);
        int b = Random.Range(0, 100);
        ui_text.text = a.ToString() + " + " + b.ToString();

        Answer1.text = (a + b).ToString();
        Answer2.text = (a + b + 1).ToString();
        Answer3.text = (a + b - 1).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
