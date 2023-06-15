using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryEverything : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Bottle")
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.name == "ObjectToThrow(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
}
