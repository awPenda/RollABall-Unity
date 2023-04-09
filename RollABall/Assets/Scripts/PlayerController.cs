using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float mvmtX;
    private float mvmtY;

    public float speed = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 mvmtVector = movementValue.Get<Vector2>();

        mvmtX = mvmtVector.x;
        mvmtY = mvmtVector.y;
    }

    private void FixedUpdate()
    {
        Vector3 mvmt = new Vector3(mvmtX, 0.0f, mvmtY);

        rb.AddForce(mvmt * speed);
    }
}

// Update is called once per frame, before the frame refreshed
//void Update()
// called before any physics applied
//void FixedUpdate
