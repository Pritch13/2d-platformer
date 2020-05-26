using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed = 5f;
    public float jumpHeight = 15f;
    private Animator anim;

    void Start() {
      anim = GetComponent<Animator>();
    }

    void Update() {

      if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
        anim.SetBool("moving", true);
      } else {
        anim.SetBool("moving", false);

      }

      Jump();
      Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
      transform.position += movement * Time.deltaTime * moveSpeed;
      
    }

  void Jump() {
    if(Input.GetKeyDown("space")) {
      gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
    }
  }

  void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("Coins")) {
      Destroy(other.gameObject);
    }
  }
}
