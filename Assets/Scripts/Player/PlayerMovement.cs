using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float straightSpeed = 3;
    public float sideSpeed = 3;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * straightSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input. GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed * -1);
            }
        }
    }
}
