using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public float movementSpeed = 200.0f;
    public float updateTime = 2.0f;
    public float elapsedTime = 0.0f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= updateTime)
        {
            elapsedTime = 0;
            int direction = Random.Range(0, 4);
            Vector3 force = Vector3.zero;
            switch (direction)
            {
                case 0:
                    force = Vector3.forward;
                    break;

                case 1:
                    force = Vector3.back;
                    break;

                case 2:
                    force = Vector3.left;
                    break;

                case 3:
                    force = Vector3.right;
                    break;
            }
            rb.AddRelativeForce(force * movementSpeed);
        }
    }
}
