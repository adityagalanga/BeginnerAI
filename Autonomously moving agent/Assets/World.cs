using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    private static GameObject[] hidingSpots;

    void Start()
    {
        hidingSpots = GameObject.FindGameObjectsWithTag("hide");
    }

    public GameObject[] GetHidingSpots()
    {
        return hidingSpots;
    }
}
