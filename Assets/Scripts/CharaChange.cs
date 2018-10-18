using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaChange : MonoBehaviour {

    public GameObject[] charaTips;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("z")) ChangeCube();
        if (Input.GetKeyDown("x")) ChangeOblong();
        if (Input.GetKeyDown("c")) ChangeVertical();
    }

    public void ChangeCube()
    {
        GameObject characterObject = (GameObject)Instantiate(
            charaTips[0]);
    }

    public void ChangeOblong()
    {
        GameObject characterObject = (GameObject)Instantiate(
            charaTips[1]);
    }

    public void ChangeVertical()
    {
        GameObject characterObject = (GameObject)Instantiate(
            charaTips[2]);
    }
}
