using UnityEngine;
using System.Collections;

public class TearController : MonoBehaviour {

    public float lifeSpan = 3f;
    private float startingTime;
    private Rigidbody2D rb;

	void Start ()
    {
        startingTime = Time.time;
        rb = this.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(4f, 0f), ForceMode2D.Impulse);
    }
	
	void Update ()
    {
        if (Time.time - startingTime > lifeSpan)
        {
            GameObject.Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "environment")
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
