using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public int score = 0;
    public GameObject scoreManager;
    public bool colliderE = true;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 6)
        {
            scoreManager.GetComponent<UIUpdate>().UpdateScore();
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
