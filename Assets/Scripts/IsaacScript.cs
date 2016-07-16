using UnityEngine;
using System.Collections;

public class IsaacScript : MonoBehaviour {

    public float speed = 1.0f;

    private Rigidbody2D rb;

	void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        Vector2 axes = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        axes.Normalize();
        axes = axes * speed;
        rb.AddForce(axes);
    }
}
