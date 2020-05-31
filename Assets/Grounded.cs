using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject Character;
    private Animator anim;


    private void Start() {
        Character = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "Ground") {
            Character.GetComponent<CharacterController>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.collider.tag == "Ground") {
            Character.GetComponent<CharacterController>().isGrounded = false;
        }
    }
}
