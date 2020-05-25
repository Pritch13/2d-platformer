using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed = 5f;
    public float jumpHeight = 5f;
    // void Start()
    // {
        
    // }

    void Update() {
      Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
      transform.position += movement * Time.deltaTime * moveSpeed;

      if ( Input.GetKeyDown("space")) {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
      }
    }
}
