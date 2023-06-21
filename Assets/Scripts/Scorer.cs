using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public int score = 0;
    public GameObject scoreManager;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 6) // if the hit object is given the layer 'bottle'
        {
            scoreManager.GetComponent<UIUpdate>().UpdateScore(); // call the UI update function from UIUpdate
            gameObject.GetComponent<CapsuleCollider>().enabled = false; // turn off the objects collider so it can only be counted once.
        }
    }
}
