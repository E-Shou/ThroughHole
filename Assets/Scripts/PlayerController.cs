using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cube;
    private Rigidbody rbody;
    public GameObject gameManager;

    Vector3 moveDirection = Vector3.zero;
    public float speedZ;
    public float speedX;
    public float speedY;
    public float accelerationZ;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up")) MoveToUp();
        if (Input.GetKeyDown("down")) MoveToDown();
        if (Input.GetKeyDown("left")) MoveToLeft();
        if (Input.GetKeyDown("right")) MoveToRight();
        if (Input.GetKeyDown("z")) ChangeCube();
        if (Input.GetKeyDown("x")) ChangeOblong();
        if (Input.GetKeyDown("c")) ChangeVertical();
        cube.transform.localPosition += new Vector3(0f, 0f, speedZ * Time.deltaTime);

    }

    public void MoveToLeft()
    {
        transform.Translate(-1, 0, 0);
    }

    public void MoveToRight()
    {
        transform.Translate(1, 0, 0);
    }

    public void MoveToDown()
    {
        transform.Translate(0, -1, 0);
    }

    public void MoveToUp()
    {
        transform.Translate(0, 1, 0);
    }

    public void ChangeCube()
    {
        cube.transform.localScale = new Vector3(1, 1, 1);
    }
    public void ChangeOblong()
    {
        cube.transform.localScale = new Vector3(1.5f, 0.5f, 1);
    }
    public void ChangeVertical()
    {
        cube.transform.localScale = new Vector3(0.5f, 1.5f, 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            gameManager.GetComponent<GameController>().GameOver();
            speedZ = 0;
            speedX = 0;
            speedY = 0;
        }
    }
}

