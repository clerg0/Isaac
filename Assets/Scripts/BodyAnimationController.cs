using UnityEngine;
using System.Collections;

public class BodyAnimationController: MonoBehaviour {

    Animator animator;

	void Start ()
    {
        animator = this.GetComponent<Animator>();
	}
	
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        animator.SetBool("up", v > 0.1f);
        animator.SetBool("down", v < -0.1f);
        animator.SetBool("right", h > 0.1f);
        animator.SetBool("left", h < -0.1f);        
    }
}
