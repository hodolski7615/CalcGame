using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text ui_text;
    public Text Answer1, Answer2, Answer3;

    private int a;
    private int b;
	// Use this for initialization
	void Start () {
        // release 브랜치 주석

        a = Random.Range(0, 100);
        b = Random.Range(0, 100);
        ui_text.text = a.ToString() + " + " + b.ToString();

        Answer1.text = (a + b).ToString();
        Answer2.text = (a + b + 1).ToString();
        Answer3.text = (a + b - 1).ToString();
        
        // master 브랜치 주석ff
    }

    public bool IsAnswerToAdd(int number1, int number2, int userAnswer)
    {
        return (number1 + number2) == userAnswer;
    }

    public void IfAnswerCorrect_ButtonColorChange(int buttonNum)
    {
        int answer = 0;
        if (buttonNum == 1)
            answer = int.Parse(Answer1.text);
        else if (buttonNum == 2)
            answer = int.Parse(Answer2.text);
        else if (buttonNum == 3)
            answer = int.Parse(Answer3.text);

        if (IsAnswerToAdd(a, b, answer))
        {
            print("correct");
        }
        else
        {
            print("wrong");
        }
        // 돌아가서 수정함
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
