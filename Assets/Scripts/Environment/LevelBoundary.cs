using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -2.69f;
    public static float rightSide = 6.273f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalRight = rightSide;
        internalLeft = leftSide;
    }
}
