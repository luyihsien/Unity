using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float roatateSpeed=0.12f;
    public float moveSpeed=0.006f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateAmount=Input.GetAxis("Horizontal")*roatateSpeed;
        float moveAmount=Input.GetAxis("Vertical")*moveSpeed;
        transform.Rotate(0,0,-rotateAmount);
        transform.Translate(0,moveAmount,0);
    }
}
