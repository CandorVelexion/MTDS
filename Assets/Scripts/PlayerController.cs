using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D rb;

    // Use this for initialization
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        }

    // Update is called once per frame
    private void Update() {

        }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * speed;
        //rb.position = new Vector2(
        //    Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
        //    Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        //);
        }
    }
