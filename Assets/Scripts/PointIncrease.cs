using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointIncrease : MonoBehaviour
{
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 50;
    }
}
