using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float mvmtX;
    private float mvmtY;
    private int count;

    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        count = 0;
        SetCountText();

        winTextObject.SetActive(false);


    }

    private void FixedUpdate()
    {
        Vector3 mvmt = new Vector3(mvmtX, 0.0f, mvmtY);

        rb.AddForce(mvmt * speed);
    }

    // move the object on player key press
    void OnMove(InputValue movementValue)
    {
        Vector2 mvmtVector = movementValue.Get<Vector2>();

        mvmtX = mvmtVector.x;
        mvmtY = mvmtVector.y;
    }

    // Run stuff when the player trigger/collide objects 
    void OnTriggerEnter(Collider other)
    {
        //if the object is Pickup, disable game object
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 7)
        {
            winTextObject.SetActive(true);
        }
    }
}

// Update is called once per frame, before the frame refreshed
//void Update()
// called before any physics applied
//void FixedUpdate
