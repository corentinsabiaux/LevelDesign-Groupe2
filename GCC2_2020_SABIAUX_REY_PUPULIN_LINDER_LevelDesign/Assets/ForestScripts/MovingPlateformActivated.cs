using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlateformActivated : MonoBehaviour
{
    public GameObject movingPlateform;

    private void OnTriggerEnter(Collider other)
    {
        movingPlateform.SetActive(true);
    }
}
