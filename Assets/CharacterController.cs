using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float moveSpeed = 5f;
    public float jumpHeight = 15f;
    public bool isGrounded = false;
    public AudioSource coinCollect;
    private Animator anim;
    public Rigidbody2D rb;
    private GameObject character;

    void Start() {
      anim = GetComponent<Animator>();
    }

    void Update() {
      TrackMovementForAnimation();
      Jump();
      Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
      transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump() {
      if(Input.GetKeyDown("space") && isGrounded) {
        anim.SetBool("jumped", true);
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
      }
    }

  void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("Coins")) {
      coinCollect.Play();
      Destroy(other.gameObject);
    }
  }

  void TrackMovementForAnimation() {
    if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
      anim.SetBool("moving", true);
    } else {
      anim.SetBool("moving", false);
    }

    Vector3 characterScale = transform.localScale;

    if(Input.GetAxis("Horizontal") < 0) {
      characterScale.x = -0.7f;
    }
      if(Input.GetAxis("Horizontal") > 0) {
      characterScale.x = 0.7f;
    }

    transform.localScale = characterScale;

    if(rb.position.y < -6) {
      FindObjectOfType<GameManager>().EndGame();
    }

  }
}
