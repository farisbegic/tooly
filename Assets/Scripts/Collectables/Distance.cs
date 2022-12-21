using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public GameObject distanceEndDisplay;
    public int distanceRun;
    public bool addingDistance = false;

    void Update()
    {
        if (!addingDistance)
        {
            addingDistance = true;
            StartCoroutine(AddingDistance());
        }
    }

    IEnumerator AddingDistance()
    {
        distanceRun++;
        distanceDisplay.GetComponent<Text>().text = "" + distanceRun;
        distanceEndDisplay.GetComponent<Text>().text = "" + distanceRun;
        yield return new WaitForSeconds(0.25f);
        addingDistance = false;
    }
}
