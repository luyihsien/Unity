using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject,0.5f);

        Debug.Log("Collision!!");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger!!");
    }

}
