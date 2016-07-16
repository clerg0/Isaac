using UnityEngine;
using System.Collections;

public class HeadAnimatorController : MonoBehaviour {

    Animator animator;

    public GameObject tearPrefab;
    public float freq = 0.2f;

	void Start ()
    {
        animator = this.GetComponent<Animator>();
	}
	
	
	void Update ()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        animator.SetBool("up", v > 0.1f);
        animator.SetBool("right", h > 0.2f);
        animator.SetBool("left", h < -0.2f);

        bool a = Input.GetButton("A");
        bool b = Input.GetButton("B");
        bool x = Input.GetButton("X");
        bool y = Input.GetButton("Y");

        Debug.Log("A = " + a + " B = " + b + " X = " + x + " Y = " + y);
    }  
}
