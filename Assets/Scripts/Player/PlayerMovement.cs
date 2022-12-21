using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float straightSpeed = 7;
    public float sideSpeed = 6;
    public static bool needChange = false;
    public GameObject player;
    public GameObject charModel;
    public GameObject distance;

    void Update()
    {
        ControlDistance();
        transform.Translate(Vector3.forward * Time.deltaTime * straightSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed * -1);
            }
        }
    }

    void ControlDistance()
    {
        int distanceValue = distance.GetComponent<Distance>().distanceRun;

        if (distanceValue > 100 && distanceValue < 200)
        {
            straightSpeed = 10;
        }

        else if (distanceValue > 200 && distanceValue < 300)
        {
            straightSpeed = 13;
        }

        else if (distanceValue > 300 && distanceValue < 400)
        {
            straightSpeed = 16;
        }

        else if (distanceValue > 400)
        {
            straightSpeed = 19;
        }
    }
}
