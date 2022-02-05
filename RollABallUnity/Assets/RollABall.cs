using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall : MonoBehaviour
{
    public float speed;
    float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        Physics.gravity = new Vector3(0, 0, 0);
    }

    //Physics.gravity = new Vector3(0, 0, 0);  

    
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= 5)
            Physics.gravity = new Vector3(0, -9, 0);


        float HorizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(HorizontalMovement, 0, VerticalMovement);

        this.GetComponent<Rigidbody>().AddForce(movement * speed);



    }
}