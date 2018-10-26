using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public PlayerController cube;
    public Text scoreLabel;
    public GameObject buttons;
    public GameObject textGameOver;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int score = CalcScore();
        scoreLabel.text = "Score : " + score + "m";

        if(PlayerPrefs.GetInt("HighScore") < score)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
	}

    int CalcScore()
    {
        return (int)cube.transform.position.z;
    }

    public void GameOver()
    {
        textGameOver.SetActive(true);
        Invoke("ReturnToTitle", 2.0f);
    }

    void ReturnToTitle()
    {
        Application.LoadLevel("Title");
    }
}
