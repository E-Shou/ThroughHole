using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    const float MinLaneX = -2.5f;
    const float MaxLaneX = 2.5f;
    const float MinLaneY = 1.0f;
    const float MaxLaneY = 4.5f;
    const float LaneWidth = 1f;
    const float LaneHeight = 1f;
    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;
    float targetLaneX;
    float targetLaneY;

    public float speedZ;
    public float speedX;
    public float speedY;
    public float accelerationZ;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left")) MoveToLeft();
        if (Input.GetKeyDown("right")) MoveToRight();
        if (Input.GetKeyDown("up")) MoveToUp();
        if (Input.GetKeyDown("down")) MoveToDown();

        float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
        moveDirection.z = Mathf.Clamp(acceleratedZ, 0, speedZ);

        float ratioX = (targetLaneX * LaneWidth - transform.position.x) / LaneWidth;
        moveDirection.x = ratioX * speedX;

        float ratioY = (targetLaneY * LaneHeight - transform.position.y) / LaneHeight;
        moveDirection.y = ratioY * speedY;

        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);
    }

    public void MoveToLeft()
    {
        if (targetLaneX > MinLaneX) targetLaneX--;
    }

    public void MoveToRight()
    {
        if (targetLaneX < MaxLaneX) targetLaneX++;
    }

    public void MoveToDown()
    {
        if (targetLaneY > MinLaneY) targetLaneY--;
    }

    public void MoveToUp()
    {
        if(targetLaneY < MaxLaneY)targetLaneY++;
    }
}

